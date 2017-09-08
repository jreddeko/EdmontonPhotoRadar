using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoRadarMap.Models.EnforcementZones.Data
{
    public class Format
    {
        public string precisionStyle { get; set; }
        public string noCommas { get; set; }
        public string align { get; set; }
        public string precision { get; set; }
        public string view { get; set; }
    }

    public class Top
    {
        public object item { get; set; }
        public int count { get; set; }
    }

    public class CachedContents
    {
        public object largest { get; set; }
        public int non_null { get; set; }
        public string average { get; set; }
        public int @null { get; set; }
        public List<Top> top { get; set; }
        public object smallest { get; set; }
        public string sum { get; set; }
    }

    public class Column
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dataTypeName { get; set; }
        public string fieldName { get; set; }
        public int position { get; set; }
        public string renderTypeName { get; set; }
        public Format format { get; set; }
        public List<string> flags { get; set; }
        public string description { get; set; }
        public int? tableColumnId { get; set; }
        public int? width { get; set; }
        public CachedContents cachedContents { get; set; }
        public List<string> subColumnTypes { get; set; }
    }

    public class BkgdLayer
    {
        public string layerKey { get; set; }
        public int opacity { get; set; }
    }

    public class DescriptionColumn
    {
        public int tableColumnId { get; set; }
    }

    public class Plot
    {
        public int locationId { get; set; }
        public int titleId { get; set; }
        public List<DescriptionColumn> descriptionColumns { get; set; }
    }

    public class ViewDefinition
    {
        public string uid { get; set; }
        public string highlightColor { get; set; }
        public string color { get; set; }
        public Plot plot { get; set; }
        public bool flyoutsNoLabel { get; set; }
        public string alias { get; set; }
        public int opacity { get; set; }
        public string plotStyle { get; set; }
    }

    public class LegendDetails
    {
        public bool showConditional { get; set; }
        public string position { get; set; }
    }

    public class DisplayFormat
    {
        public List<BkgdLayer> bkgdLayers { get; set; }
        public bool disableGeolocator { get; set; }
        public bool exclusiveLayers { get; set; }
        public List<ViewDefinition> viewDefinitions { get; set; }
        public LegendDetails legendDetails { get; set; }
    }

    public class Grant
    {
        public bool inherited { get; set; }
        public string type { get; set; }
        public List<string> flags { get; set; }
    }

    public class License
    {
        public string name { get; set; }
    }

    public class Order
    {
        public string columnFieldName { get; set; }
        public bool ascending { get; set; }
    }

    public class JsonQuery
    {
        public List<Order> order { get; set; }
    }

    public class Condition
    {
        public int tableColumnId { get; set; }
        public string _key { get; set; }
        public int value { get; set; }
        public string @operator { get; set; }
    }

    public class ConditionalFormatting
    {
        public Condition condition { get; set; }
        public string color { get; set; }
        public string description { get; set; }
    }

    public class Visible
    {
        public bool map { get; set; }
    }

    public class RenderTypeConfig
    {
        public Visible visible { get; set; }
    }

    public class Metadata
    {
        public JsonQuery jsonQuery { get; set; }
        public string rdfSubject { get; set; }
        public string rdfClass { get; set; }
        public List<ConditionalFormatting> conditionalFormatting { get; set; }
        public object custom_fields { get; set; }
        public string rowIdentifier { get; set; }
        public List<string> availableDisplayTypes { get; set; }
        public RenderTypeConfig renderTypeConfig { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public int lastNotificationSeenAt { get; set; }
        public bool privilegesDisabled { get; set; }
        public string profileImageUrlLarge { get; set; }
        public string profileImageUrlMedium { get; set; }
        public string profileImageUrlSmall { get; set; }
        public string roleName { get; set; }
        public string screenName { get; set; }
        public List<string> rights { get; set; }
    }

    public class TableColumnId
    {
        public int __invalid_name__14355114 { get; set; }
    }

    public class Metadata2
    {
        public TableColumnId tableColumnId { get; set; }
        public string @operator { get; set; }
        public List<List<int>> customValues { get; set; }
    }

    public class Child
    {
        public string type { get; set; }
        public string value { get; set; }
        public Metadata2 metadata { get; set; }
    }

    public class Metadata3
    {
        public bool advanced { get; set; }
        public int unifiedVersion { get; set; }
    }

    public class FilterCondition
    {
        public string type { get; set; }
        public string value { get; set; }
        public List<Child> children { get; set; }
        public Metadata3 metadata { get; set; }
    }

    public class Expression
    {
        public int columnId { get; set; }
        public string type { get; set; }
    }

    public class OrderBy
    {
        public bool ascending { get; set; }
        public Expression expression { get; set; }
    }

    public class Query
    {
        public FilterCondition filterCondition { get; set; }
        public List<OrderBy> orderBys { get; set; }
    }

    public class TableAuthor
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public int lastNotificationSeenAt { get; set; }
        public bool privilegesDisabled { get; set; }
        public string profileImageUrlLarge { get; set; }
        public string profileImageUrlMedium { get; set; }
        public string profileImageUrlSmall { get; set; }
        public string roleName { get; set; }
        public string screenName { get; set; }
        public List<string> rights { get; set; }
    }

    public class View
    {
        public string id { get; set; }
        public string name { get; set; }
        public int averageRating { get; set; }
        public string category { get; set; }
        public int createdAt { get; set; }
        public string description { get; set; }
        public string displayType { get; set; }
        public int downloadCount { get; set; }
        public bool hideFromCatalog { get; set; }
        public bool hideFromDataJson { get; set; }
        public int indexUpdatedAt { get; set; }
        public string licenseId { get; set; }
        public bool moderationStatus { get; set; }
        public bool newBackend { get; set; }
        public int numberOfComments { get; set; }
        public int oid { get; set; }
        public string previewImageId { get; set; }
        public string provenance { get; set; }
        public bool publicationAppendEnabled { get; set; }
        public int publicationDate { get; set; }
        public int publicationGroup { get; set; }
        public string publicationStage { get; set; }
        public string rowClass { get; set; }
        public int rowsUpdatedAt { get; set; }
        public string rowsUpdatedBy { get; set; }
        public int tableId { get; set; }
        public int totalTimesRated { get; set; }
        public int viewCount { get; set; }
        public int viewLastModified { get; set; }
        public string viewType { get; set; }
        public List<Column> columns { get; set; }
        public DisplayFormat displayFormat { get; set; }
        public List<Grant> grants { get; set; }
        public License license { get; set; }
        public Metadata metadata { get; set; }
        public Owner owner { get; set; }
        public Query query { get; set; }
        public List<string> rights { get; set; }
        public TableAuthor tableAuthor { get; set; }
        public List<string> tags { get; set; }
    }

    public class Meta
    {
        public View view { get; set; }
    }

    public class RootObject
    {
        public Meta meta { get; set; }
        public List<List<object>> data { get; set; }
    }
}