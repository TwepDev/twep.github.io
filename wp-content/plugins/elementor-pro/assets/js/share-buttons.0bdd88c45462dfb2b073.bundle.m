/*! elementor-pro - v3.8.2 - 21-11-2022 */
"use strict";(self.webpackChunkelementor_pro=self.webpackChunkelementor_pro||[]).push([[58],{4112:(e,t)=>{Object.defineProperty(t,"__esModule",{value:!0}),t.default=void 0;var s=elementorModules.frontend.handlers.Base.extend({async onInit(){if(!this.isActive())return;elementorModules.frontend.handlers.Base.prototype.onInit.apply(this,arguments);const e=this.getElementSettings(),t=this.getSettings("classes"),s=e.share_url&&e.share_url.url,n={classPrefix:t.shareLinkPrefix};s?n.url=e.share_url.url:(n.url=location.href,n.title=elementorFrontend.config.post.title,n.text=elementorFrontend.config.post.excerpt,n.image=elementorFrontend.config.post.featuredImage),!window.ShareLink&&elementorFrontend.utils.assetsLoader&&await elementorFrontend.utils.assetsLoader.load("script","share-link"),this.elements.$shareButton.shareLink&&this.elements.$shareButton.shareLink(n)},getDefaultSettings:()=>({selectors:{shareButton:".elementor-share-btn"},classes:{shareLinkPrefix:"elementor-share-btn_"}}),getDefaultElements(){var e=this.getSettings("selectors");return{$shareButton:this.$element.find(e.shareButton)}},isActive:()=>!elementorFrontend.isEditMode()});t.default=s}}]);