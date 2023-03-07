@-webkit-keyframes animateRainbow {
  0% {
    background-position: 0% 50%;
  }
  50% {
    background-position: 100% 50%;
  }
  100% {
    background-position: 0% 50%;
  }
}
@keyframes animateRainbow {
  0% {
    background-position: 0% 50%;
  }
  50% {
    background-position: 100% 50%;
  }
  100% {
    background-position: 0% 50%;
  }
}
.eael-progressbar-line-rainbow .eael-progressbar-line-fill {
  background: -webkit-gradient(linear, right top, left top, from(#9400d3), color-stop(#4b0082), color-stop(#0000ff), color-stop(#00ff00), color-stop(#ffff00), color-stop(#ff7f00), to(#ff0000));
  background: -o-linear-gradient(right, #9400d3, #4b0082, #0000ff, #00ff00, #ffff00, #ff7f00, #ff0000);
  background: linear-gradient(270deg, #9400d3, #4b0082, #0000ff, #00ff00, #ffff00, #ff7f00, #ff0000);
  background-size: 500% 500%;
  -webkit-animation: animateRainbow 5s ease infinite;
          animation: animateRainbow 5s ease infinite;
}
.eael-progressbar-circle-fill .eael-progressbar-circle-half {
  background-color: #000000;
}
.eael-progressbar-half-circle-fill .eael-progressbar-circle-half {
  background-color: #000000;
}
.eael-progressbar-box {
  width: 100%;
  height: 200px;
  border: 1px solid #eeeeee;
  margin: 0 auto;
}
.eael-progressbar-box .eael-progressbar-box-inner-content {
  display: block;
  width: 100%;
  position: absolute;
  top: 50%;
  -webkit-transform: translateY(-50%);
      -ms-transform: translateY(-50%);
          transform: translateY(-50%);
  text-align: center;
  z-index: 9;
}
.eael-progressbar-box .eael-progressbar-count-wrap {
  font-size: 28px;
  font-weight: 700;
}
.eael-progressbar-box .eael-progressbar-title {
  font-size: 16px;
  font-weight: 400;
}
.eael-progressbar-box-fill {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  height: 0;
  background-color: #000000;
  -webkit-transition: height 1500ms linear;
  -o-transition: height 1500ms linear;
  transition: height 1500ms linear;
}
