.swiper-container-wrap .swiper-slide .eael-social-feed-element img {
  width: 100%;
}

/*--- Twitter Feed Styles ---*/

.eael-social-feed-element.hidden {
  background-color: red !important;
}

.eael-twitter-feed-wrapper::before, .eael-twitter-feed-wrapper::after,
.eael-twitter-feed-container::before, .eael-twitter-feed-container::after {
  content: "";
  clear: both;
}

.eael-social-feed-element .pull-left {
  float: left;
  margin-right: 10px;
}

.eael-social-feed-element .pull-right {
  margin-left: 10px;
}

.eael-social-feed-element img {
  width: 100%;
  height: auto;
  border: 0;
  vertical-align: middle;
  -ms-interpolation-mode: bicubic;
}

.eael-social-feed-element .attachment {
  vertical-align: middle;
  -ms-interpolation-mode: bicubic;
}

/*--- Link styles ---*/

.eael-social-feed-element a {
  color: #0088cc;
  text-decoration: none;
}

.eael-social-feed-element a:focus {
  outline: thin dotted #333;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}

.eael-social-feed-element a:hover,
.eael-social-feed-element a:active {
  outline: 0;
  color: #005580;
  text-decoration: underline;
}

/*--- Text styles ---*/

.eael-social-feed-element small {
  font-size: 85%;
}

.eael-social-feed-element strong {
  font-weight: bold;
}

.eael-social-feed-element em {
  font-style: italic;
}

.eael-social-feed-element p {
  margin: 0 0 10px;
}

.eael-social-feed-element .media-body > p {
  margin-bottom: 4px;
  min-height: 20px;
}

.eael-social-feed-element p.social-feed-text {
  margin: 0;
  overflow: hidden;
  -o-text-overflow: ellipsis;
     text-overflow: ellipsis;
  -webkit-line-clamp: 5;
  -webkit-box-orient: vertical;
}

/*--- Message styles ---*/

.eael-social-feed-element,
.eael-social-feed-element .media-body {
  overflow: hidden;
  zoom: 1;
  overflow: visible;
}

.eael-social-feed-element {
  padding: 0;
  background: none;
}

.eael-social-feed-element .media-body .social-network-icon {
  margin-top: -3px;
  margin-right: 5px;
  width: 16px;
}

.eael-social-feed-element .media-body div {
  color: #666;
  line-height: 20px;
  clear: both;
}

.eael-social-feed-element:first-child {
  margin-top: 0;
}

.eael-social-feed-element .media-object {
  display: block;
  width: 48px;
  border-radius: 50%;
}

.eael-social-feed-element .media-heading {
  margin: 0 0 5px;
}

.eael-social-feed-element .media-list {
  margin-left: 0;
  list-style: none;
}

.eael-social-feed-element .muted {
  color: #999;
}

.eael-social-feed-element a.muted:hover,
.eael-social-feed-element a.muted:focus {
  color: #808080;
}

.eael-social-feed-element {
  -webkit-transition: 0.25s;
  -o-transition: 0.25s;
  transition: 0.25s;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  margin: -1px;
  margin-top: 25px;
  color: #333;
  text-align: left;
  font-size: 14px;
  font-family: "Helvetica Neue", Helvetica, Arial, sans-serif;
  line-height: 16px;
}

.eael-social-feed-element .eael-content {
  padding: 20px 15px 15px;
  -webkit-transition: 0.4s;
  -o-transition: 0.4s;
  transition: 0.4s;
  background: #fff;
}

.eael-social-feed-element .social-network-icon {
  opacity: 0.7;
}

.eael-social-feed-element .author-title {
  color: #444;
  line-height: 1.5em;
  font-weight: 500;
}

/*--- Icon Color ---*/

.media-body .fa-twitter {
  color: #1da1f2;
  margin-right: 8px;
}

.media-body .fa-facebook {
  color: #3b5998;
  margin-right: 8px;
}

/*--- Read More Link ---*/

.text-wrapper p .read-more-link {
  margin-top: 9px;
  display: block;
}

/*--- Navigation Links ---*/

.eael-social-feed-wrapper .slick-prev, .eael-social-feed-element .slick-next {
  background: #1da1f2;
}

/*--- Loading Loader ---*/

.eael-social-feed-wrapper {
  width: 100%;
  height: auto;
  position: relative;
  z-index: 0;
}

.eael-loading-feed {
  display: none;
  position: absolute;
  width: 100%;
  height: 100%;
  top: 0px;
  left: 0px;
  bottom: 0px;
  right: 0px;
}

.eael-loading-feed.show-loading {
  display: block;
  text-align: center;
  z-index: 10;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: center;
      -ms-flex-align: center;
          align-items: center;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-transition: 0.5s;
  -o-transition: 0.5s;
  transition: 0.5s;
}

.eael-loading-feed .loader {
  border: 3px solid #f3f3f3;
  border-radius: 50%;
  border-top: 3px solid #3498db;
  width: 30px;
  height: 30px;
  -webkit-animation: spin 2s linear infinite;
  /* Safari */
  animation: spin 2s linear infinite;
  margin: 0 auto;
}

/*--- Safari ---*/

@-webkit-keyframes spin {
  0% {
    -webkit-transform: rotate(0deg);
  }
  100% {
    -webkit-transform: rotate(360deg);
  }
}

@keyframes spin {
  0% {
    -webkit-transform: rotate(0deg);
            transform: rotate(0deg);
  }
  100% {
    -webkit-transform: rotate(360deg);
            transform: rotate(360deg);
  }
}

/*--- List View ---*/

.eael-social-feed-container.list-view .eael-social-feed-element {
  margin: 15px;
  border: 1px solid rgba(0, 0, 0, 0.1);
  background: none;
}

/*--- Carousel View ---*/

.eael-social-feed-container.carousel-view {
  width: 100%;
  height: auto;
}

.eael-social-feed-element {
  margin: 0px;
}

/*--- Masonry View ---*/

.eael-twitter-feed-container.masonry-view .eael-social-feed-element {
  width: 33.33%;
  margin-top: 0px;
  float: left;
}

.eael-social-feed-element .eael-content {
  border: 1px solid rgba(0, 0, 0, 0.1);
}

/*--- Editor Related Style ---*/

.eael-social-feed-avatar-circle .eael-social-feed-element .media-object {
  border-radius: 50%;
}

.eael-social-feed-avatar-square .eael-social-feed-element .media-object {
  border-radius: 0%;
}

.eael-social-feed-masonry-col-4 .eael-social-feed-element .social-feed-date .eael-social-feed-masonry-col-4 .eael-social-feed-element .social-feed-date {
  text-align: left !important;
}

/*--- Media Query ---*/

@media only screen and (min-width: 768px) and (max-width: 992px) {
  .eael-twitter-feed-container.masonry-view .eael-social-feed-element {
    width: 50% !important;
  }
}

@media only screen and (max-width: 480px) {
  .eael-twitter-feed-container.masonry-view .eael-social-feed-element {
    width: 100% !important;
  }
}
