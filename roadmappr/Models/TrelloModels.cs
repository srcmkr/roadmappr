using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace roadmappr.Models
{
    [ExcludeFromCodeCoverage]
    public class Trello
    {
        [JsonProperty("lastDbUpdate")]
        public DateTime LastDbUpdate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("descData")]
        public DescDataClass DescData { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("idOrganization")]
        public string IdOrganization { get; set; }

        [JsonProperty("limits")]
        public TrelloLimits Limits { get; set; }

        [JsonProperty("pinned")]
        public string Pinned { get; set; }

        [JsonProperty("starred")]
        public string Starred { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("prefs")]
        public TrelloPrefs Prefs { get; set; }

        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("subscribed")]
        public string Subscribed { get; set; }

        [JsonProperty("labelNames")]
        public LabelNames LabelNames { get; set; }

        [JsonProperty("powerUps")]
        public object[] PowerUps { get; set; }

        [JsonProperty("dateLastActivity")]
        public object DateLastActivity { get; set; }

        [JsonProperty("dateLastView")]
        public object DateLastView { get; set; }

        [JsonProperty("shortUrl")]
        public Uri ShortUrl { get; set; }

        [JsonProperty("idTags")]
        public string[] IdTags { get; set; }

        [JsonProperty("datePluginDisable")]
        public object DatePluginDisable { get; set; }

        [JsonProperty("creationMethod")]
        public object CreationMethod { get; set; }

        [JsonProperty("actions")]
        public Action[] Actions { get; set; }

        [JsonProperty("cards")]
        public CardElement[] Cards { get; set; }

        [JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [JsonProperty("lists")]
        public ListElement[] Lists { get; set; }

        [JsonProperty("members")]
        public MemberElement[] Members { get; set; }

        [JsonProperty("checklists")]
        public ChecklistElement[] Checklists { get; set; }

        [JsonProperty("customFields")]
        public object[] CustomFields { get; set; }

        [JsonProperty("memberships")]
        public Membership[] Memberships { get; set; }

        [JsonProperty("pluginData")]
        public object[] PluginData { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Action
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idMemberCreator")]
        public string IdMemberCreator { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public object Date { get; set; }

        [JsonProperty("limits")]
        public ActionLimits Limits { get; set; }

        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        public MemberCreatorClass Member { get; set; }

        [JsonProperty("memberCreator", NullValueHandling = NullValueHandling.Ignore)]
        public MemberCreatorClass MemberCreator { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Data
    {
        [JsonProperty("board")]
        public Board Board { get; set; }

        [JsonProperty("idMemberAdded", NullValueHandling = NullValueHandling.Ignore)]
        public string IdMemberAdded { get; set; }

        [JsonProperty("memberType", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberType { get; set; }

        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public DataList List { get; set; }

        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public DataCard Card { get; set; }

        [JsonProperty("old", NullValueHandling = NullValueHandling.Ignore)]
        public Old Old { get; set; }

        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public DataAttachment Attachment { get; set; }

        [JsonProperty("listAfter", NullValueHandling = NullValueHandling.Ignore)]
        public ListAfterClass ListAfter { get; set; }

        [JsonProperty("listBefore", NullValueHandling = NullValueHandling.Ignore)]
        public ListAfterClass ListBefore { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("deactivated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivated { get; set; }

        [JsonProperty("idMember", NullValueHandling = NullValueHandling.Ignore)]
        public string IdMember { get; set; }

        [JsonProperty("checkItem", NullValueHandling = NullValueHandling.Ignore)]
        public DataCheckItem CheckItem { get; set; }

        [JsonProperty("checklist", NullValueHandling = NullValueHandling.Ignore)]
        public ListAfterClass Checklist { get; set; }

        [JsonProperty("plugin", NullValueHandling = NullValueHandling.Ignore)]
        public Plugin Plugin { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("textData", NullValueHandling = NullValueHandling.Ignore)]
        public DescDataClass TextData { get; set; }

        [JsonProperty("dateLastEdited", NullValueHandling = NullValueHandling.Ignore)]
        public object DateLastEdited { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class DataAttachment
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("edgeColor", NullValueHandling = NullValueHandling.Ignore)]
        public string EdgeColor { get; set; }

        [JsonProperty("previewUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PreviewUrl { get; set; }

        [JsonProperty("previewUrl2x", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PreviewUrl2X { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Board
    {
        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("prefs", NullValueHandling = NullValueHandling.Ignore)]
        public BoardPrefs Prefs { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class BoardPrefs
    {
        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background { get; set; }

        [JsonProperty("selfJoin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelfJoin { get; set; }

        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public string Comments { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class DataCard
    {
        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("idShort")]
        public long IdShort { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        [JsonProperty("idList", NullValueHandling = NullValueHandling.Ignore)]
        public string IdList { get; set; }

        [JsonProperty("pos", NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos { get; set; }

        [JsonProperty("idAttachmentCover", NullValueHandling = NullValueHandling.Ignore)]
        public string IdAttachmentCover { get; set; }

        [JsonProperty("due", NullValueHandling = NullValueHandling.Ignore)]
        public object Due { get; set; }

        [JsonProperty("closed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closed { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class DataCheckItem
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ListAfterClass
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class DataList
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("closed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closed { get; set; }

        [JsonProperty("pos", NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Old
    {
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        [JsonProperty("idList", NullValueHandling = NullValueHandling.Ignore)]
        public string IdList { get; set; }

        [JsonProperty("pos", NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("closed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closed { get; set; }

        [JsonProperty("idAttachmentCover", NullValueHandling = NullValueHandling.Ignore)]
        public string IdAttachmentCover { get; set; }

        [JsonProperty("prefs", NullValueHandling = NullValueHandling.Ignore)]
        public BoardPrefs Prefs { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Plugin
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class DescDataClass
    {
        [JsonProperty("emoji")]
        public DescDataEmoji Emoji { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class DescDataEmoji
    {
    }

    [ExcludeFromCodeCoverage]
    public class ActionLimits
    {
        [JsonProperty("reactions", NullValueHandling = NullValueHandling.Ignore)]
        public Reactions Reactions { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Reactions
    {
        [JsonProperty("perAction")]
        public PerBoard PerAction { get; set; }

        [JsonProperty("uniquePerAction")]
        public PerBoard UniquePerAction { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class PerBoard
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public long DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public long WarnAt { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class MemberCreatorClass
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("avatarHash")]
        public string AvatarHash { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("idMemberReferrer")]
        public string IdMemberReferrer { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class CardElement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("checkItemStates")]
        public object CheckItemStates { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("creationMethod")]
        public object CreationMethod { get; set; }

        [JsonProperty("dateLastActivity")]
        public object DateLastActivity { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        public string DescLimited()
        {
            if (Desc == null) return string.Empty;

            return Desc.Length > 60 ? string.Concat(Desc.Substring(0, 60), "...") : Desc;
        }

        [JsonProperty("descData")]
        public DescDataClass DescData { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("idList")]
        public string IdList { get; set; }

        [JsonProperty("idMembersVoted")]
        public string[] IdMembersVoted { get; set; }

        [JsonProperty("idShort")]
        public long IdShort { get; set; }

        [JsonProperty("idAttachmentCover")]
        public string IdAttachmentCover { get; set; }

        [JsonProperty("limits")]
        public CardLimits Limits { get; set; }

        [JsonProperty("idLabels")]
        public string[] IdLabels { get; set; }

        [JsonProperty("manualCoverAttachment")]
        public string ManualCoverAttachment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("badges")]
        public Badges Badges { get; set; }

        [JsonProperty("dueComplete")]
        public string DueComplete { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }

        [JsonProperty("idChecklists")]
        public string[] IdChecklists { get; set; }

        [JsonProperty("idMembers")]
        public object[] IdMembers { get; set; }

        [JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [JsonProperty("shortUrl")]
        public Uri ShortUrl { get; set; }

        [JsonProperty("subscribed")]
        public string Subscribed { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("attachments")]
        public AttachmentElement[] Attachments { get; set; }

        [JsonProperty("pluginData")]
        public object[] PluginData { get; set; }

        [JsonProperty("customFieldItems")]
        public object[] CustomFieldItems { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class AttachmentElement
    {
        [JsonProperty("bytes")]
        public long? Bytes { get; set; }

        [JsonProperty("date")]
        public object Date { get; set; }

        [JsonProperty("edgeColor")]
        public string EdgeColor { get; set; }

        [JsonProperty("idMember")]
        public string IdMember { get; set; }

        [JsonProperty("isUpload")]
        public string IsUpload { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("previews")]
        public Preview[] Previews { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("pos")]
        public long Pos { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Preview
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("bytes")]
        public long Bytes { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("scaled")]
        public string Scaled { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Badges
    {
        [JsonProperty("votes")]
        public long Votes { get; set; }

        [JsonProperty("attachmentsByType")]
        public AttachmentsByType AttachmentsByType { get; set; }

        [JsonProperty("viewingMemberVoted")]
        public string ViewingMemberVoted { get; set; }

        [JsonProperty("subscribed")]
        public string Subscribed { get; set; }

        [JsonProperty("fogbugz")]
        public string Fogbugz { get; set; }

        [JsonProperty("checkItems")]
        public long CheckItems { get; set; }

        [JsonProperty("checkItemsChecked")]
        public long CheckItemsChecked { get; set; }

        [JsonProperty("comments")]
        public long Comments { get; set; }

        [JsonProperty("attachments")]
        public long Attachments { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }

        [JsonProperty("dueComplete")]
        public string DueComplete { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class AttachmentsByType
    {
        [JsonProperty("trello")]
        public TrelloClass Trello { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class TrelloClass
    {
        [JsonProperty("board")]
        public long Board { get; set; }

        [JsonProperty("card")]
        public long Card { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Label
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class CardLimits
    {
        [JsonProperty("attachments")]
        public StickersClass Attachments { get; set; }

        [JsonProperty("checklists")]
        public StickersClass Checklists { get; set; }

        [JsonProperty("stickers")]
        public StickersClass Stickers { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class StickersClass
    {
        [JsonProperty("perCard")]
        public PerBoard PerCard { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ChecklistElement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("idCard")]
        public string IdCard { get; set; }

        [JsonProperty("pos")]
        public long Pos { get; set; }

        [JsonProperty("limits")]
        public ChecklistLimits Limits { get; set; }

        [JsonProperty("checkItems")]
        public CheckItemElement[] CheckItems { get; set; }

        [JsonProperty("creationMethod")]
        public object CreationMethod { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class CheckItemElement
    {
        [JsonProperty("idChecklist")]
        public string IdChecklist { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameData")]
        public object NameData { get; set; }

        [JsonProperty("pos")]
        public long Pos { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ChecklistLimits
    {
        [JsonProperty("checkItems")]
        public CheckItems CheckItems { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class CheckItems
    {
        [JsonProperty("perChecklist")]
        public PerBoard PerChecklist { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class LabelNames
    {
        [JsonProperty("green")]
        public string Green { get; set; }

        [JsonProperty("yellow")]
        public string Yellow { get; set; }

        [JsonProperty("orange")]
        public string Orange { get; set; }

        [JsonProperty("red")]
        public string Red { get; set; }

        [JsonProperty("purple")]
        public string Purple { get; set; }

        [JsonProperty("blue")]
        public string Blue { get; set; }

        [JsonProperty("sky")]
        public string Sky { get; set; }

        [JsonProperty("lime")]
        public string Lime { get; set; }

        [JsonProperty("pink")]
        public string Pink { get; set; }

        [JsonProperty("black")]
        public string Black { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class TrelloLimits
    {
        [JsonProperty("attachments")]
        public CustomFieldsClass Attachments { get; set; }

        [JsonProperty("boards")]
        public Boards Boards { get; set; }

        [JsonProperty("cards")]
        public ListsClass Cards { get; set; }

        [JsonProperty("checklists")]
        public CustomFieldsClass Checklists { get; set; }

        [JsonProperty("customFields")]
        public CustomFieldsClass CustomFields { get; set; }

        [JsonProperty("labels")]
        public CustomFieldsClass Labels { get; set; }

        [JsonProperty("lists")]
        public ListsClass Lists { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class CustomFieldsClass
    {
        [JsonProperty("perBoard")]
        public PerBoard PerBoard { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Boards
    {
        [JsonProperty("totalMembersPerBoard")]
        public PerBoard TotalMembersPerBoard { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ListsClass
    {
        [JsonProperty("openPerBoard")]
        public PerBoard OpenPerBoard { get; set; }

        [JsonProperty("totalPerBoard")]
        public PerBoard TotalPerBoard { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ListElement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("subscribed")]
        public string Subscribed { get; set; }

        [JsonProperty("cards")]
        public object Cards { get; set; }

        [JsonProperty("limits")]
        public ListLimits Limits { get; set; }

        [JsonProperty("creationMethod")]
        public object CreationMethod { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ListLimits
    {
        [JsonProperty("cards")]
        public PurpleCards Cards { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class PurpleCards
    {
        [JsonProperty("openPerList")]
        public PerBoard OpenPerList { get; set; }

        [JsonProperty("totalPerList")]
        public PerBoard TotalPerList { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class MemberElement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("avatarHash")]
        public string AvatarHash { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("bioData")]
        public BioData BioData { get; set; }

        [JsonProperty("confirmed")]
        public string Confirmed { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("idEnterprisesDeactivated")]
        public object[] IdEnterprisesDeactivated { get; set; }

        [JsonProperty("idMemberReferrer")]
        public string IdMemberReferrer { get; set; }

        [JsonProperty("idPremOrgsAdmin")]
        public object[] IdPremOrgsAdmin { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("memberType")]
        public string MemberType { get; set; }

        [JsonProperty("products")]
        public long[] Products { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class BioData
    {
        [JsonProperty("emoji")]
        public BioDataEmoji Emoji { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class BioDataEmoji
    {
        [JsonProperty("brett", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Brett { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class Membership
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idMember")]
        public string IdMember { get; set; }

        [JsonProperty("unconfirmed")]
        public string Unconfirmed { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class TrelloPrefs
    {
        [JsonProperty("permissionLevel")]
        public string PermissionLevel { get; set; }

        [JsonProperty("voting")]
        public string Voting { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("invitations")]
        public string Invitations { get; set; }

        [JsonProperty("selfJoin")]
        public string SelfJoin { get; set; }

        [JsonProperty("cardCovers")]
        public string CardCovers { get; set; }

        [JsonProperty("calendarFeedEnabled")]
        public string CalendarFeedEnabled { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("backgroundImage")]
        public object BackgroundImage { get; set; }

        [JsonProperty("backgroundImageScaled")]
        public object BackgroundImageScaled { get; set; }

        [JsonProperty("backgroundTile")]
        public string BackgroundTile { get; set; }

        [JsonProperty("backgroundBrightness")]
        public string BackgroundBrightness { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("backgroundBottomColor")]
        public string BackgroundBottomColor { get; set; }

        [JsonProperty("backgroundTopColor")]
        public string BackgroundTopColor { get; set; }

        [JsonProperty("canBePublic")]
        public string CanBePublic { get; set; }

        [JsonProperty("canBeOrg")]
        public string CanBeOrg { get; set; }

        [JsonProperty("canBePrivate")]
        public string CanBePrivate { get; set; }

        [JsonProperty("canInvite")]
        public string CanInvite { get; set; }
    }
}
