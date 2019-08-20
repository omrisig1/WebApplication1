
// Daniel Shiffman
// http://codingtra.in
// http://patreon.com/codingtrain
// Code for: https://youtu.be/QHEQuoIKgNE

var circles, spots;
var img;
var density;
// var bg;

var MAX = 65;

function preload() {
  img = loadImage("/assets/OtoSpa2.png");
  // bg = createImg('assets/giphy.gif', c);
}

function setup() {
  var canvas = createCanvas(img.width, img.height);
  canvas.parent('sketch-holder');

  density = displayDensity();
  pixelDensity(1);
  img.loadPixels();
  spots = [];
  circles = [];
  for (var x = 0; x < img.width; x++) {
    for (var y = 0; y < img.height; y++) {
      var index = x + y * img.width;
      var c = img.pixels[index*4];
      var b = brightness([c]);
      if (b > 1) {
        spots.push(createVector(x, y));
      }
    }
  }
  logThings();
}

function logThings() {
  defaultLogger.log(img.width, 'sketch.js');
  defaultLogger.log(img.height, 'sketch.js');
  defaultLogger.log(img.pixels.length, 'sketch.js');
  defaultLogger.log(spots.length, 'sketch.js');
  defaultLogger.log(density, 'sketch.js');
}

function draw() {
  // background(0);
  var total = 10;
  var count = 0;
  var attempts = 0;

  while (count < total) {
    var newC = newCircle();
    if (newC !== null) {
      circles.push(newC);
      count++;
    }
    attempts++;
    if (attempts > MAX) {
      noLoop();
      defaultLogger.log("finished", 'sketch.js');
      break;
    }
  }

  for (var i = 0; i < circles.length; i++) {
    var circle = circles[i];

    if (circle.growing) {
      if (circle.edges() || circle.r > random(10,15)) {
        circle.growing = false;
      } else {
        for (var j = 0; j < circles.length; j++) {
          var other = circles[j];
          if (circle !== other) {
            var d = dist(circle.x, circle.y, other.x, other.y);
            var distance = circle.r + other.r;

            if (d - 5 < distance) {
              circle.growing = false;
              break;
            }
          }
        }
      }
    }
    circle.show();
    circle.grow();
  }
}

function newCircle() {
  var r = int(random(0, spots.length));
  var spot = spots[r];
  var x = spot.x;
  var y = spot.y;

  var valid = true;
  for (var i = 0; i < circles.length; i++) {
    var circle = circles[i];
    var d = dist(x, y, circle.x, circle.y);
    if (d < circle.r) {
      valid = false;
      break;
    }
  }
  if (valid) {
    return new Circle(x, y);
  } else {
    return null;
  }
}
