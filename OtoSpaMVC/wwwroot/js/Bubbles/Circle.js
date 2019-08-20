// Daniel Shiffman
// http://codingtra.in
// http://patreon.com/codingtrain
// Code for: https://youtu.be/QHEQuoIKgNE

function Circle(x, y) {
  this.x = x;
  this.y = y;
  this.r = random(1,3);
  this.growing = true;

  this.grow = function() {
    if (this.growing) {
      this.r += 0.5;
    }
  }

  this.show = function() {
    stroke(90,200,250,100);
    strokeWeight(1);
    fill(0,200,255,5);
    ellipse(this.x, this.y, this.r * 2, this.r * 2);
  }

  this.edges = function() {
    return (this.x + this.r >= width || this.x - this.r <= 0 || this.y + this.r >= height || this.y - this.r <= 0)
  }
}
