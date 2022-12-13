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
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Homepage Box Title: Enter the box title for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homepageBoxTitle")]
		public virtual string HomepageBoxTitle => this.Value<string>(_publishedValueFallback, "homepageBoxTitle");

		///<summary>
		/// Homepage Description: Enter a description for home page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homepageDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString HomepageDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "homepageDescription");

		///<summary>
		/// Homepage Image: Choose the main image for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homepageMainImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HomepageMainImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "homepageMainImage");

		///<summary>
		/// Homepage Subtitle: Enter a subtitle for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homepageSubtitle")]
		public virtual string HomepageSubtitle => this.Value<string>(_publishedValueFallback, "homepageSubtitle");

		///<summary>
		/// Homepage Title: Enter a title for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homepageTitle")]
		public virtual string HomepageTitle => this.Value<string>(_publishedValueFallback, "homepageTitle");

		///<summary>
		/// Limbobo Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("limboboIcon")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LimboboIcon => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "limboboIcon");

		///<summary>
		/// Limbobo Video
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("limboboVideo")]
		public virtual string LimboboVideo => this.Value<string>(_publishedValueFallback, "limboboVideo");

		///<summary>
		/// Dropdown List
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("list")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MapList> List => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MapList>>(_publishedValueFallback, "list");

		///<summary>
		/// Map Icon Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapIconDescription")]
		public virtual string MapIconDescription => this.Value<string>(_publishedValueFallback, "mapIconDescription");

		///<summary>
		/// Map Icon Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapIconImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops MapIconImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "mapIconImage");

		///<summary>
		/// Map Icon Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapIconSubtitle")]
		public virtual string MapIconSubtitle => this.Value<string>(_publishedValueFallback, "mapIconSubtitle");

		///<summary>
		/// Map Icon Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapIconTitle")]
		public virtual string MapIconTitle => this.Value<string>(_publishedValueFallback, "mapIconTitle");

		///<summary>
		/// Map Icon Video
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapIconVideo")]
		public virtual string MapIconVideo => this.Value<string>(_publishedValueFallback, "mapIconVideo");

		///<summary>
		/// Map Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapLocation")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel MapLocation => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "mapLocation");

		///<summary>
		/// Offers Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offersCaption")]
		public virtual string OffersCaption => this.Value<string>(_publishedValueFallback, "offersCaption");

		///<summary>
		/// Offers Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offersDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OffersDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "offersDescription");

		///<summary>
		/// Offers Heading: Enter a heading for this section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offersHeading")]
		public virtual string OffersHeading => this.Value<string>(_publishedValueFallback, "offersHeading");

		///<summary>
		/// Offers Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offersSubHeading")]
		public virtual string OffersSubHeading => this.Value<string>(_publishedValueFallback, "offersSubHeading");

		///<summary>
		/// VISA & IMMIGRATION
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown1")]
		public virtual global::Umbraco.Cms.Core.Models.Link Touchdown1 => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "touchdown1");

		///<summary>
		/// Touchdown1 Content: Enter the Content for touchdown
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown1Content")]
		public virtual string Touchdown1Content => this.Value<string>(_publishedValueFallback, "touchdown1Content");

		///<summary>
		/// Touchdown1 Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown1Image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Touchdown1Image => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "touchdown1Image");

		///<summary>
		/// Touchdown1 Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown1Title")]
		public virtual string Touchdown1Title => this.Value<string>(_publishedValueFallback, "touchdown1Title");

		///<summary>
		/// INTERNATIONAL TRAVEL UPDATES
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown2")]
		public virtual global::Umbraco.Cms.Core.Models.Link Touchdown2 => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "touchdown2");

		///<summary>
		/// Touchdown2 Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown2Content")]
		public virtual string Touchdown2Content => this.Value<string>(_publishedValueFallback, "touchdown2Content");

		///<summary>
		/// Touchdown2 Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown2Image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Touchdown2Image => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "touchdown2Image");

		///<summary>
		/// Touchdown2 Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown2Title")]
		public virtual string Touchdown2Title => this.Value<string>(_publishedValueFallback, "touchdown2Title");

		///<summary>
		/// INTERNATIONAL TRAVEL UPDATES
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown3")]
		public virtual global::Umbraco.Cms.Core.Models.Link Touchdown3 => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "touchdown3");

		///<summary>
		/// Touchdown3 Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown3Content")]
		public virtual string Touchdown3Content => this.Value<string>(_publishedValueFallback, "touchdown3Content");

		///<summary>
		/// Touchdown3 Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown3Image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Touchdown3Image => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "touchdown3Image");

		///<summary>
		/// Touchdown3 Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown3Title")]
		public virtual string Touchdown3Title => this.Value<string>(_publishedValueFallback, "touchdown3Title");

		///<summary>
		/// GETTING HERE
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown4")]
		public virtual global::Umbraco.Cms.Core.Models.Link Touchdown4 => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "touchdown4");

		///<summary>
		/// Touchdown4 Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown4Content")]
		public virtual string Touchdown4Content => this.Value<string>(_publishedValueFallback, "touchdown4Content");

		///<summary>
		/// Touchdown4 Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown4Image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Touchdown4Image => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "touchdown4Image");

		///<summary>
		/// TouchDown4 MainContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchDown4MainContent")]
		public virtual string TouchDown4MainContent => this.Value<string>(_publishedValueFallback, "touchDown4MainContent");

		///<summary>
		/// Touchdown4 Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown4Title")]
		public virtual string Touchdown4Title => this.Value<string>(_publishedValueFallback, "touchdown4Title");

		///<summary>
		/// GETTING AROUND
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown5")]
		public virtual global::Umbraco.Cms.Core.Models.Link Touchdown5 => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "touchdown5");

		///<summary>
		/// Touchdown5 Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown5Content")]
		public virtual string Touchdown5Content => this.Value<string>(_publishedValueFallback, "touchdown5Content");

		///<summary>
		/// Touchdown5 Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown5Image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Touchdown5Image => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "touchdown5Image");

		///<summary>
		/// Touchdown5 Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("touchdown5Title")]
		public virtual string Touchdown5Title => this.Value<string>(_publishedValueFallback, "touchdown5Title");

		///<summary>
		/// Video Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("videoLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link VideoLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "videoLink");
	}
}
