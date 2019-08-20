
/*
 *  # [disclaimer]:
 *  The following amalgemation of code is part of our collage .Net-MVC5 project demand,
 *  displaying a D3.js graph with some data for the admin web-interface.
 *  This code was borrowed and changed from the following lovely person at:
 *    - https://bl.ocks.org/kerryrodden/766f8f6d31f645c39f488a0befa1e3c8
 *    - https://bl.ocks.org/kerryrodden/477c1bfb081b783f80ad
 *  All rights and restrictions of respective open-source licesnces apply as mentioned in the original works.
 *  We kindly thank @kerryrodden for making these projects open-source and available !~
 */

var width = 750,
    height = 604,
    radius = (Math.min(width, height) / 2) - 10;

var formatNumber = d3.format(",d");

var x = d3.scale.linear()
    .range([0, 2 * Math.PI]);

var y = d3.scale.sqrt()
    .range([0, radius]);

var color = d3.scale.category20b();
// var color = d3.interpolateSpectral

var partition = d3.layout.partition()
    .value(function(d) { return d.size; });

var arc = d3.svg.arc()
    .startAngle(function(d) { return Math.max(0, Math.min(2 * Math.PI, x(d.x))); })
    .endAngle(function(d) { return Math.max(0, Math.min(2 * Math.PI, x(d.x + d.dx))); })
    .innerRadius(function(d) { return Math.max(0, y(d.y)); })
    .outerRadius(function(d) { return Math.max(0, y(d.y + d.dy)); });

var svg = d3.select("#chart").append("svg")
    .attr("width", width)
    .attr("height", height)
  .append("g")
    .attr("id", "container")
    .attr("transform", "translate(" + width / 2 + "," + (height / 2) + ")");

// Breadcrumb dimensions: width, height, spacing, width of tip/tail.
    var b = {
      w: 75, h: 30, s: 3, t: 10
    };

var colors = {
  "1star": "#ff4000",
  "2star": "#ffbf00",
  "3star": "#ffff00",
  "4star": "#bfff00",
  "5star": "#80ff00",
};

// Total size of all segments; we set this later, after loading the data.
var totalSize = 0;

var chosenRoot;
var graphRoot;

// ----------------------------

var mainGraph = function (text) {
    var csv = d3.csv.parseRows(text);
    var json = buildHierarchy(csv);
    createVisualization(json);
    mouseleave();
};

// Main function to draw and set up the visualization, once we have the data.
function createVisualization(json) {

  initializeBreadcrumbTrail();
  var root = json;
  defaultLogger.log(root, 'zoomSunburst.js');

  svg.append("svg:circle")
      .attr("id","circle")
      .attr("r", radius)
      .style("opacity", 0);

  // $(document).on("click",function(e){
  //   e.stopPropagation();
     defaultLogger.log(this, 'zoomSunburst.js');
     defaultLogger.log(e, 'zoomSunburst.js');
     defaultLogger.log(e.target.id, 'zoomSunburst.js');
  //   if (e.target!=="svg"){
  //     defaultLogger.log("save", 'zoomSunburst.js');
  //     ExitToRoot();
  //   }
  // });

  var path = svg.selectAll("path")
      .data(partition.nodes(root))
      .enter().append("path")
      .attr("d", arc)
      .style("fill", function(d) { return colors[d.name]; })
      //.style("fill", function(d) { return color((d.children ? d : d.parent).name); })
      .on("click", click)
      .on("mouseover", mouseover)
      .append("title")
      .text(function(d) { return d.name + "\n" + formatNumber(d.value); });
  // });

  // Add the mouseleave handler to the bounding circle.
  d3.select("#container").on("mouseleave", mouseleave);

  graphRoot = path.node().__data__;
  chosenRoot= graphRoot;
}

function click(d) {
  defaultLogger.log("click", 'zoomSunburst.js');
  defaultLogger.log(d, 'zoomSunburst.js');
  document.getElementById("ToRoot").disabled = (d.name === "root");
  chosenRoot = d;
  svg.transition()
      .duration(750)
      .tween("scale", function() {
        var xd = d3.interpolate(x.domain(), [d.x, d.x + d.dx]),
            yd = d3.interpolate(y.domain(), [d.y, 1]),
            yr = d3.interpolate(y.range(), [d.y ? 20 : 0, radius]);
        return function(t) { x.domain(xd(t)); y.domain(yd(t)).range(yr(t)); };
      })
    .selectAll("path")
      .attrTween("d", function(d) { return function() { return arc(d); }; });
}

// Given a node in a partition layout, return an array of all of its ancestor
// nodes, highest first, but excluding the root.
function getAncestors(node) {
  var path = [];
  var current = node;
  while (current.parent) {
    path.unshift(current);
    current = current.parent;
  }
  return path;
}

// Update the breadcrumb trail to show the current sequence and percentage.
function updateBreadcrumbs(nodeArray, percentageString) {

  // Data join; key function combines name and depth (= position in sequence).
  var g = d3.select("#trail")
      .selectAll("g")
      .data(nodeArray, function(d) { return d.name + d.depth; });

  // Add breadcrumb and label for entering nodes.
  var entering = g.enter().append("svg:g");

  entering.append("svg:polygon")
      .attr("points", breadcrumbPoints)
      .style("fill", function(d) { return colors[d.name]; });

  entering.append("svg:text")
      .attr("x", (b.w + b.t) / 2)
      .attr("y", b.h / 2)
      .attr("dy", "0.35em")
      .attr("text-anchor", "middle")
      .text(function(d) { return d.name; });

  // Set position for entering and updating nodes.
  g.attr("transform", function(d, i) {
    return "translate(" + i * (b.w + b.s) + ", 0)";
  });

  // Remove exiting nodes.
  g.exit().remove();

  // Now move and update the percentage at the end.
  d3.select("#trail").select("#endlabel")
      .attr("x", (nodeArray.length + 0.5) * (b.w + b.s))
      .attr("y", b.h / 2)
      .attr("dy", "0.35em")
      .attr("text-anchor", "middle")
      .text(percentageString);

  // Make the breadcrumb trail visible, if it's hidden.
  d3.select("#trail")
      .style("visibility", "");

}

function mouseover(d) {
  if ((chosenRoot!==graphRoot&&d===chosenRoot.parent)||(d===graphRoot))
    return mouseleave();

  var percentage = (100 * d.value / chosenRoot.value).toPrecision(3);
  var percentageString = percentage + "%";
  if (percentage < 0.1) {
    percentageString = "< 0.1%";
  }
  defaultLogger.log(percentageString, 'zoomSunburst.js');
  defaultLogger.log(percentage, 'zoomSunburst.js');

  d3.select("#percentage")
      .text(percentageString);
  d3.select("#pr_group")
      .text(chosenRoot.name);

  d3.select("#explanation")
      .style("visibility", "");

      var sequenceArray = getAncestors(d);
      updateBreadcrumbs(sequenceArray, percentageString);

      // Fade all the segments.
      d3.selectAll("path")
          .style("opacity", 0.3);

      // Then highlight only those that are an ancestor of the current segment.
      svg.selectAll("path")
          .filter(function(node) {
                    return (sequenceArray.indexOf(node) >= 0);
                  })
          .style("opacity", 1);
}

function mouseleave() {
  //defaultLogger.log("mouseLeave", 'zoomSunburst.js');

  // Hide the breadcrumb trail
  d3.select("#trail")
      .style("visibility", "hidden");

  // Deactivate all segments during transition.
  d3.selectAll("path").on("mouseover", null);

  // Transition each segment to full opacity and then reactivate it.
  d3.selectAll("path")
      .transition()
      .duration(750)
      .style("opacity", 1)
      .each("end", function() {
              d3.select(this).on("mouseover", mouseover);
            });

  d3.select("#explanation")
      .style("visibility", "hidden");

    var sequenceArray = [chosenRoot];
    updateBreadcrumbs(sequenceArray, "");

}

function initializeBreadcrumbTrail() {
  // Add the svg area.
  var trail = d3.select("#sequence").append("svg:svg")
      .attr("width", width)
      .attr("height", 50)
      .attr("id", "trail");
  // Add the label at the end, for the percentage.
  trail.append("svg:text")
    .attr("id", "endlabel")
    .style("fill", "#000");
}

function ExitToRoot(){
  click(graphRoot);
  //mouseleave();
}

// d3.select(self.frameElement).style("height", height + "px");


// -------------------------------------

// Take a 2-column CSV and transform it into a hierarchical structure suitable
// for a partition layout. The first column is a sequence of step names, from
// root to leaf, separated by hyphens. The second column is a count of how
// often that sequence occurred.
function buildHierarchy(csv) {
  var allWords = new Set();
  var root = {"name": "root", "children": []};
  for (var i = 0; i < csv.length; i++) {
    var sequence = csv[i][0];
    var size = +csv[i][1];
    if (isNaN(size)) { // e.g. if this is a header row
      continue;
    }
    var parts = sequence.split("-");
    parts.forEach(p=>allWords.add(p));
    var currentNode = root;
    for (var j = 0; j < parts.length; j++) {
      var children = currentNode["children"];
      defaultLogger.log(children, 'zoomSunburst.js');
      var nodeName = parts[j];
      var childNode;
      if (j + 1 < parts.length) {
   // Not yet at the end of the sequence; move down the tree.
 	var foundChild = false;
 	for (var k = 0; k < children.length; k++) {
 	  if (children[k]["name"] == nodeName) {
 	    childNode = children[k];
        defaultLogger.log(children,'zoomSunburst.js');
 	    foundChild = true;
 	    break;
 	  }
 	}
  // If we don't already have a child node for this branch, create it.
 	if (!foundChild) {
 	  childNode = {"name": nodeName, "children": []};
 	  children.push(childNode);
 	}
 	currentNode = childNode;
      } else {
 	// Reached the end of the sequence; create a leaf node.
 	childNode = {"name": nodeName, "size": size};
 	children.push(childNode);
      }
    }
  }
  initAllColors(allWords);
  return root;
};

function initAllColors(words) {
  for (w of words)
    if (!colors[w])
      colors[w] = stringToColour(w);
    else defaultLogger.log(w, 'zoomSunburst.js');
  let temp = {};
  Object.keys(colors).sort().reverse()
  .forEach(
    key=>temp[key]=colors[key]
  );
  defaultLogger.log(temp,'zoomSunburst.js');//colors.sort();
  colors = temp;
}

function stringToColour(str) {
    var hash = 0;
    for (var i = 0; i < str.length; i++) {
        hash = str.charCodeAt(i) + ((hash << 5) - hash);
    }
    var colour = '#';
    for (var i = 0; i < 3; i++) {
        var value = (hash >> (i * 8)) & 0xFF;
        colour += ('00' + value.toString(16)).substr(-2);
    }
    return colour;
}

// -----------------------------------

function initializeBreadcrumbTrail() {
  // Add the svg area.
  var trail = d3.select("#sequence").append("svg:svg")
      .attr("width", width-100)
      .attr("height", 50)
      .attr("id", "trail");
  // Add the label at the end, for the percentage.
  trail.append("svg:text")
    .attr("id", "endlabel")
    .style("fill", "#000");
}

var curW = b.w;
// Generate a string that describes the points of a breadcrumb polygon.
function breadcrumbPoints(d, i) {
  var len = visualLength(d.name) + b.t;
  curW = Math.max(b.w, len);
  var points = [];
  points.push("0,0");
  points.push(b.w + ",0");
  points.push(b.w + b.t + "," + (b.h / 2));
  points.push(b.w + "," + b.h);
  points.push("0," + b.h);
  if (i > 0) { // Leftmost breadcrumb; don't include 6th vertex.
    points.push(b.t + "," + (b.h / 2));
  }
  return points.join(" ");
}

function visualLength(label) {
    var dom = document.getElementById("ruler");
    if (!dom) {
        dom = document.createElement("div")
        dom.setAttribute("id", "ruler");
        dom.style.cssText = "display:block;width:0;border:0;margin:0;padding:0;overflow:hidden;text-size:12px;";
        document.body.appendChild(dom);
    }
    dom.innerHTML = label;
    return dom.scrollWidth;
}

// Update the breadcrumb trail to show the current sequence and percentage.
function updateBreadcrumbs(nodeArray, percentageString) {

  // Data join; key function combines name and depth (= position in sequence).
  var g = d3.select("#trail")
      .selectAll("g")
      .data(nodeArray, function(d) { return d.name + d.depth; });

  // Add breadcrumb and label for entering nodes.
  var entering = g.enter().append("svg:g");

  entering.append("svg:polygon")
      .attr("points", breadcrumbPoints)
      .style("fill", function(d) { return colors[d.name]; });

  entering.append("svg:text")
      .attr("x", (b.w + b.t) / 2)
      .attr("y", b.h / 2)
      .attr("dy", "0.35em")
      .attr("text-anchor", "middle")
      .text(function(d) { return d.name; });

  // Set position for entering and updating nodes.
  g.attr("transform", function(d, i) {
    return "translate(" + i * (b.w + b.s) + ", 0)";
  });

  // Remove exiting nodes.
  g.exit().remove();

  // Now move and update the percentage at the end.
  d3.select("#trail").select("#endlabel")
      .attr("x", (nodeArray.length + 0.5) * (b.w + b.s))
      .attr("y", b.h / 2)
      .attr("dy", "0.35em")
      .attr("text-anchor", "middle")
      .text(percentageString);

  // Make the breadcrumb trail visible, if it's hidden.
  d3.select("#trail")
      .style("visibility", "");

}
