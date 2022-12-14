//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.3.2+e7fae14
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, IFooterContainer, IHeaderContainer
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Home(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Copyright
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("copyright")]
		public virtual string Copyright => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetCopyright(this, _publishedValueFallback);

		///<summary>
		/// Disclaimer Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("disclaimerLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link DisclaimerLink => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetDisclaimerLink(this, _publishedValueFallback);

		///<summary>
		/// Facebook Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("facebookLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link FacebookLink => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetFacebookLink(this, _publishedValueFallback);

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent FooterLogo => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetFooterLogo(this, _publishedValueFallback);

		///<summary>
		/// Footer Services
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerServices")]
		public virtual global::Umbraco.Cms.Web.Common.PublishedModels.ListBlock FooterServices => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetFooterServices(this, _publishedValueFallback);

		///<summary>
		/// Instagram Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("instagramLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link InstagramLink => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetInstagramLink(this, _publishedValueFallback);

		///<summary>
		/// Offers & Promotions
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offersPromotions")]
		public virtual global::Umbraco.Cms.Web.Common.PublishedModels.SpecialOffersAndPromotions OffersPromotions => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetOffersPromotions(this, _publishedValueFallback);

		///<summary>
		/// Privacy Policy Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("privacyPolicyLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link PrivacyPolicyLink => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetPrivacyPolicyLink(this, _publishedValueFallback);

		///<summary>
		/// Twitter Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twitterLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link TwitterLink => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetTwitterLink(this, _publishedValueFallback);

		///<summary>
		/// Youtube Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("youtubeLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link YoutubeLink => global::Umbraco.Cms.Web.Common.PublishedModels.FooterContainer.GetYoutubeLink(this, _publishedValueFallback);

		///<summary>
		/// Header Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent HeaderLogo => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderContainer.GetHeaderLogo(this, _publishedValueFallback);

		///<summary>
		/// Header Menu Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerMenuItems")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HeaderMenuItem> HeaderMenuItems => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderContainer.GetHeaderMenuItems(this, _publishedValueFallback);
	}
}
