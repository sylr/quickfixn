// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PartyRiskLimitsDefinitionRequest : Message
        {
            public const string MsgType = "CS";

            public PartyRiskLimitsDefinitionRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CS"));
            }

            public PartyRiskLimitsDefinitionRequest(
                    QuickFix.Fields.RiskLimitRequestID aRiskLimitRequestID
                ) : this()
            {
                this.RiskLimitRequestID = aRiskLimitRequestID;
            }

            public QuickFix.Fields.RiskLimitRequestID RiskLimitRequestID
            {
                get
                {
                    QuickFix.Fields.RiskLimitRequestID val = new QuickFix.Fields.RiskLimitRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RiskLimitRequestID val)
            {
                this.RiskLimitRequestID = val;
            }

            public QuickFix.Fields.RiskLimitRequestID Get(QuickFix.Fields.RiskLimitRequestID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RiskLimitRequestID val)
            {
                return IsSetRiskLimitRequestID();
            }

            public bool IsSetRiskLimitRequestID()
            {
                return IsSetField(Tags.RiskLimitRequestID);
            }
            public QuickFix.Fields.NoRequestingPartyIDs NoRequestingPartyIDs
            {
                get
                {
                    QuickFix.Fields.NoRequestingPartyIDs val = new QuickFix.Fields.NoRequestingPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoRequestingPartyIDs val)
            {
                this.NoRequestingPartyIDs = val;
            }

            public QuickFix.Fields.NoRequestingPartyIDs Get(QuickFix.Fields.NoRequestingPartyIDs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoRequestingPartyIDs val)
            {
                return IsSetNoRequestingPartyIDs();
            }

            public bool IsSetNoRequestingPartyIDs()
            {
                return IsSetField(Tags.NoRequestingPartyIDs);
            }
            public QuickFix.Fields.NoPartyRiskLimits NoPartyRiskLimits
            {
                get
                {
                    QuickFix.Fields.NoPartyRiskLimits val = new QuickFix.Fields.NoPartyRiskLimits();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPartyRiskLimits val)
            {
                this.NoPartyRiskLimits = val;
            }

            public QuickFix.Fields.NoPartyRiskLimits Get(QuickFix.Fields.NoPartyRiskLimits val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPartyRiskLimits val)
            {
                return IsSetNoPartyRiskLimits();
            }

            public bool IsSetNoPartyRiskLimits()
            {
                return IsSetField(Tags.NoPartyRiskLimits);
            }
            public QuickFix.Fields.Text Text
            {
                get
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Text val)
            {
                this.Text = val;
            }

            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Text val)
            {
                return IsSetText();
            }

            public bool IsSetText()
            {
                return IsSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen EncodedTextLen
            {
                get
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedTextLen val)
            {
                this.EncodedTextLen = val;
            }

            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedTextLen val)
            {
                return IsSetEncodedTextLen();
            }

            public bool IsSetEncodedTextLen()
            {
                return IsSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText EncodedText
            {
                get
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedText val)
            {
                this.EncodedText = val;
            }

            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedText val)
            {
                return IsSetEncodedText();
            }

            public bool IsSetEncodedText()
            {
                return IsSetField(Tags.EncodedText);
            }
            public class NoRequestingPartyIDsGroup : Group
            {
                public static int[] fieldOrder = { Tags.RequestingPartyID, Tags.RequestingPartyIDSource, Tags.RequestingPartyRole, Tags.NoRequestingPartySubIDs, Tags.RequestingPartyRoleQualifier, 0 };

                public NoRequestingPartyIDsGroup()
                  : base(Tags.NoRequestingPartyIDs, Tags.RequestingPartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRequestingPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.RequestingPartyID RequestingPartyID
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyID val = new QuickFix.Fields.RequestingPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyID val)
                {
                    this.RequestingPartyID = val;
                }

                public QuickFix.Fields.RequestingPartyID Get(QuickFix.Fields.RequestingPartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyID val)
                {
                    return IsSetRequestingPartyID();
                }

                public bool IsSetRequestingPartyID()
                {
                    return IsSetField(Tags.RequestingPartyID);
                }
                public QuickFix.Fields.RequestingPartyIDSource RequestingPartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyIDSource val = new QuickFix.Fields.RequestingPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyIDSource val)
                {
                    this.RequestingPartyIDSource = val;
                }

                public QuickFix.Fields.RequestingPartyIDSource Get(QuickFix.Fields.RequestingPartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyIDSource val)
                {
                    return IsSetRequestingPartyIDSource();
                }

                public bool IsSetRequestingPartyIDSource()
                {
                    return IsSetField(Tags.RequestingPartyIDSource);
                }
                public QuickFix.Fields.RequestingPartyRole RequestingPartyRole
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyRole val = new QuickFix.Fields.RequestingPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyRole val)
                {
                    this.RequestingPartyRole = val;
                }

                public QuickFix.Fields.RequestingPartyRole Get(QuickFix.Fields.RequestingPartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyRole val)
                {
                    return IsSetRequestingPartyRole();
                }

                public bool IsSetRequestingPartyRole()
                {
                    return IsSetField(Tags.RequestingPartyRole);
                }
                public QuickFix.Fields.NoRequestingPartySubIDs NoRequestingPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoRequestingPartySubIDs val = new QuickFix.Fields.NoRequestingPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoRequestingPartySubIDs val)
                {
                    this.NoRequestingPartySubIDs = val;
                }

                public QuickFix.Fields.NoRequestingPartySubIDs Get(QuickFix.Fields.NoRequestingPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoRequestingPartySubIDs val)
                {
                    return IsSetNoRequestingPartySubIDs();
                }

                public bool IsSetNoRequestingPartySubIDs()
                {
                    return IsSetField(Tags.NoRequestingPartySubIDs);
                }
                public QuickFix.Fields.RequestingPartyRoleQualifier RequestingPartyRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyRoleQualifier val = new QuickFix.Fields.RequestingPartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyRoleQualifier val)
                {
                    this.RequestingPartyRoleQualifier = val;
                }

                public QuickFix.Fields.RequestingPartyRoleQualifier Get(QuickFix.Fields.RequestingPartyRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyRoleQualifier val)
                {
                    return IsSetRequestingPartyRoleQualifier();
                }

                public bool IsSetRequestingPartyRoleQualifier()
                {
                    return IsSetField(Tags.RequestingPartyRoleQualifier);
                }
                public class NoRequestingPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.RequestingPartySubID, Tags.RequestingPartySubIDType, 0 };

                    public NoRequestingPartySubIDsGroup()
                      : base(Tags.NoRequestingPartySubIDs, Tags.RequestingPartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRequestingPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.RequestingPartySubID RequestingPartySubID
                    {
                        get
                        {
                            QuickFix.Fields.RequestingPartySubID val = new QuickFix.Fields.RequestingPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RequestingPartySubID val)
                    {
                        this.RequestingPartySubID = val;
                    }

                    public QuickFix.Fields.RequestingPartySubID Get(QuickFix.Fields.RequestingPartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RequestingPartySubID val)
                    {
                        return IsSetRequestingPartySubID();
                    }

                    public bool IsSetRequestingPartySubID()
                    {
                        return IsSetField(Tags.RequestingPartySubID);
                    }
                    public QuickFix.Fields.RequestingPartySubIDType RequestingPartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.RequestingPartySubIDType val = new QuickFix.Fields.RequestingPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RequestingPartySubIDType val)
                    {
                        this.RequestingPartySubIDType = val;
                    }

                    public QuickFix.Fields.RequestingPartySubIDType Get(QuickFix.Fields.RequestingPartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RequestingPartySubIDType val)
                    {
                        return IsSetRequestingPartySubIDType();
                    }

                    public bool IsSetRequestingPartySubIDType()
                    {
                        return IsSetField(Tags.RequestingPartySubIDType);
                    }

                }
            }
            public class NoPartyRiskLimitsGroup : Group
            {
                public static int[] fieldOrder = { Tags.ListUpdateAction, Tags.NoPartyDetails, Tags.NoRiskLimits, Tags.RiskLimitID, Tags.RiskLimitCheckModelType, Tags.PartyRiskLimitStatus, 0 };

                public NoPartyRiskLimitsGroup()
                  : base(Tags.NoPartyRiskLimits, Tags.ListUpdateAction, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyRiskLimitsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.ListUpdateAction ListUpdateAction
                {
                    get
                    {
                        QuickFix.Fields.ListUpdateAction val = new QuickFix.Fields.ListUpdateAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ListUpdateAction val)
                {
                    this.ListUpdateAction = val;
                }

                public QuickFix.Fields.ListUpdateAction Get(QuickFix.Fields.ListUpdateAction val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ListUpdateAction val)
                {
                    return IsSetListUpdateAction();
                }

                public bool IsSetListUpdateAction()
                {
                    return IsSetField(Tags.ListUpdateAction);
                }
                public QuickFix.Fields.NoPartyDetails NoPartyDetails
                {
                    get
                    {
                        QuickFix.Fields.NoPartyDetails val = new QuickFix.Fields.NoPartyDetails();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoPartyDetails val)
                {
                    this.NoPartyDetails = val;
                }

                public QuickFix.Fields.NoPartyDetails Get(QuickFix.Fields.NoPartyDetails val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoPartyDetails val)
                {
                    return IsSetNoPartyDetails();
                }

                public bool IsSetNoPartyDetails()
                {
                    return IsSetField(Tags.NoPartyDetails);
                }
                public QuickFix.Fields.NoRiskLimits NoRiskLimits
                {
                    get
                    {
                        QuickFix.Fields.NoRiskLimits val = new QuickFix.Fields.NoRiskLimits();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoRiskLimits val)
                {
                    this.NoRiskLimits = val;
                }

                public QuickFix.Fields.NoRiskLimits Get(QuickFix.Fields.NoRiskLimits val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoRiskLimits val)
                {
                    return IsSetNoRiskLimits();
                }

                public bool IsSetNoRiskLimits()
                {
                    return IsSetField(Tags.NoRiskLimits);
                }
                public QuickFix.Fields.RiskLimitID RiskLimitID
                {
                    get
                    {
                        QuickFix.Fields.RiskLimitID val = new QuickFix.Fields.RiskLimitID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RiskLimitID val)
                {
                    this.RiskLimitID = val;
                }

                public QuickFix.Fields.RiskLimitID Get(QuickFix.Fields.RiskLimitID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RiskLimitID val)
                {
                    return IsSetRiskLimitID();
                }

                public bool IsSetRiskLimitID()
                {
                    return IsSetField(Tags.RiskLimitID);
                }
                public QuickFix.Fields.RiskLimitCheckModelType RiskLimitCheckModelType
                {
                    get
                    {
                        QuickFix.Fields.RiskLimitCheckModelType val = new QuickFix.Fields.RiskLimitCheckModelType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RiskLimitCheckModelType val)
                {
                    this.RiskLimitCheckModelType = val;
                }

                public QuickFix.Fields.RiskLimitCheckModelType Get(QuickFix.Fields.RiskLimitCheckModelType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RiskLimitCheckModelType val)
                {
                    return IsSetRiskLimitCheckModelType();
                }

                public bool IsSetRiskLimitCheckModelType()
                {
                    return IsSetField(Tags.RiskLimitCheckModelType);
                }
                public QuickFix.Fields.PartyRiskLimitStatus PartyRiskLimitStatus
                {
                    get
                    {
                        QuickFix.Fields.PartyRiskLimitStatus val = new QuickFix.Fields.PartyRiskLimitStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRiskLimitStatus val)
                {
                    this.PartyRiskLimitStatus = val;
                }

                public QuickFix.Fields.PartyRiskLimitStatus Get(QuickFix.Fields.PartyRiskLimitStatus val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRiskLimitStatus val)
                {
                    return IsSetPartyRiskLimitStatus();
                }

                public bool IsSetPartyRiskLimitStatus()
                {
                    return IsSetField(Tags.PartyRiskLimitStatus);
                }
                public class NoPartyDetailsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.PartyDetailID, Tags.PartyDetailIDSource, Tags.PartyDetailRole, Tags.PartyDetailRoleQualifier, Tags.NoPartyDetailSubIDs, Tags.NoPartyDetailAltID, Tags.NoRelatedPartyDetailID, Tags.PartyDetailStatus, 0 };

                    public NoPartyDetailsGroup()
                      : base(Tags.NoPartyDetails, Tags.PartyDetailID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoPartyDetailsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.PartyDetailID PartyDetailID
                    {
                        get
                        {
                            QuickFix.Fields.PartyDetailID val = new QuickFix.Fields.PartyDetailID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartyDetailID val)
                    {
                        this.PartyDetailID = val;
                    }

                    public QuickFix.Fields.PartyDetailID Get(QuickFix.Fields.PartyDetailID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartyDetailID val)
                    {
                        return IsSetPartyDetailID();
                    }

                    public bool IsSetPartyDetailID()
                    {
                        return IsSetField(Tags.PartyDetailID);
                    }
                    public QuickFix.Fields.PartyDetailIDSource PartyDetailIDSource
                    {
                        get
                        {
                            QuickFix.Fields.PartyDetailIDSource val = new QuickFix.Fields.PartyDetailIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartyDetailIDSource val)
                    {
                        this.PartyDetailIDSource = val;
                    }

                    public QuickFix.Fields.PartyDetailIDSource Get(QuickFix.Fields.PartyDetailIDSource val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartyDetailIDSource val)
                    {
                        return IsSetPartyDetailIDSource();
                    }

                    public bool IsSetPartyDetailIDSource()
                    {
                        return IsSetField(Tags.PartyDetailIDSource);
                    }
                    public QuickFix.Fields.PartyDetailRole PartyDetailRole
                    {
                        get
                        {
                            QuickFix.Fields.PartyDetailRole val = new QuickFix.Fields.PartyDetailRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartyDetailRole val)
                    {
                        this.PartyDetailRole = val;
                    }

                    public QuickFix.Fields.PartyDetailRole Get(QuickFix.Fields.PartyDetailRole val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartyDetailRole val)
                    {
                        return IsSetPartyDetailRole();
                    }

                    public bool IsSetPartyDetailRole()
                    {
                        return IsSetField(Tags.PartyDetailRole);
                    }
                    public QuickFix.Fields.PartyDetailRoleQualifier PartyDetailRoleQualifier
                    {
                        get
                        {
                            QuickFix.Fields.PartyDetailRoleQualifier val = new QuickFix.Fields.PartyDetailRoleQualifier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartyDetailRoleQualifier val)
                    {
                        this.PartyDetailRoleQualifier = val;
                    }

                    public QuickFix.Fields.PartyDetailRoleQualifier Get(QuickFix.Fields.PartyDetailRoleQualifier val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartyDetailRoleQualifier val)
                    {
                        return IsSetPartyDetailRoleQualifier();
                    }

                    public bool IsSetPartyDetailRoleQualifier()
                    {
                        return IsSetField(Tags.PartyDetailRoleQualifier);
                    }
                    public QuickFix.Fields.NoPartyDetailSubIDs NoPartyDetailSubIDs
                    {
                        get
                        {
                            QuickFix.Fields.NoPartyDetailSubIDs val = new QuickFix.Fields.NoPartyDetailSubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoPartyDetailSubIDs val)
                    {
                        this.NoPartyDetailSubIDs = val;
                    }

                    public QuickFix.Fields.NoPartyDetailSubIDs Get(QuickFix.Fields.NoPartyDetailSubIDs val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoPartyDetailSubIDs val)
                    {
                        return IsSetNoPartyDetailSubIDs();
                    }

                    public bool IsSetNoPartyDetailSubIDs()
                    {
                        return IsSetField(Tags.NoPartyDetailSubIDs);
                    }
                    public QuickFix.Fields.NoPartyDetailAltID NoPartyDetailAltID
                    {
                        get
                        {
                            QuickFix.Fields.NoPartyDetailAltID val = new QuickFix.Fields.NoPartyDetailAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoPartyDetailAltID val)
                    {
                        this.NoPartyDetailAltID = val;
                    }

                    public QuickFix.Fields.NoPartyDetailAltID Get(QuickFix.Fields.NoPartyDetailAltID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoPartyDetailAltID val)
                    {
                        return IsSetNoPartyDetailAltID();
                    }

                    public bool IsSetNoPartyDetailAltID()
                    {
                        return IsSetField(Tags.NoPartyDetailAltID);
                    }
                    public QuickFix.Fields.NoRelatedPartyDetailID NoRelatedPartyDetailID
                    {
                        get
                        {
                            QuickFix.Fields.NoRelatedPartyDetailID val = new QuickFix.Fields.NoRelatedPartyDetailID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoRelatedPartyDetailID val)
                    {
                        this.NoRelatedPartyDetailID = val;
                    }

                    public QuickFix.Fields.NoRelatedPartyDetailID Get(QuickFix.Fields.NoRelatedPartyDetailID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailID val)
                    {
                        return IsSetNoRelatedPartyDetailID();
                    }

                    public bool IsSetNoRelatedPartyDetailID()
                    {
                        return IsSetField(Tags.NoRelatedPartyDetailID);
                    }
                    public QuickFix.Fields.PartyDetailStatus PartyDetailStatus
                    {
                        get
                        {
                            QuickFix.Fields.PartyDetailStatus val = new QuickFix.Fields.PartyDetailStatus();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartyDetailStatus val)
                    {
                        this.PartyDetailStatus = val;
                    }

                    public QuickFix.Fields.PartyDetailStatus Get(QuickFix.Fields.PartyDetailStatus val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartyDetailStatus val)
                    {
                        return IsSetPartyDetailStatus();
                    }

                    public bool IsSetPartyDetailStatus()
                    {
                        return IsSetField(Tags.PartyDetailStatus);
                    }
                    public class NoPartyDetailSubIDsGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.PartyDetailSubID, Tags.PartyDetailSubIDType, 0 };

                        public NoPartyDetailSubIDsGroup()
                          : base(Tags.NoPartyDetailSubIDs, Tags.PartyDetailSubID, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoPartyDetailSubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.PartyDetailSubID PartyDetailSubID
                        {
                            get
                            {
                                QuickFix.Fields.PartyDetailSubID val = new QuickFix.Fields.PartyDetailSubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.PartyDetailSubID val)
                        {
                            this.PartyDetailSubID = val;
                        }

                        public QuickFix.Fields.PartyDetailSubID Get(QuickFix.Fields.PartyDetailSubID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.PartyDetailSubID val)
                        {
                            return IsSetPartyDetailSubID();
                        }

                        public bool IsSetPartyDetailSubID()
                        {
                            return IsSetField(Tags.PartyDetailSubID);
                        }
                        public QuickFix.Fields.PartyDetailSubIDType PartyDetailSubIDType
                        {
                            get
                            {
                                QuickFix.Fields.PartyDetailSubIDType val = new QuickFix.Fields.PartyDetailSubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.PartyDetailSubIDType val)
                        {
                            this.PartyDetailSubIDType = val;
                        }

                        public QuickFix.Fields.PartyDetailSubIDType Get(QuickFix.Fields.PartyDetailSubIDType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.PartyDetailSubIDType val)
                        {
                            return IsSetPartyDetailSubIDType();
                        }

                        public bool IsSetPartyDetailSubIDType()
                        {
                            return IsSetField(Tags.PartyDetailSubIDType);
                        }

                    }
                    public class NoPartyDetailAltIDGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.PartyDetailAltID, Tags.PartyDetailAltIDSource, Tags.NoPartyDetailAltSubIDs, 0 };

                        public NoPartyDetailAltIDGroup()
                          : base(Tags.NoPartyDetailAltID, Tags.PartyDetailAltID, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoPartyDetailAltIDGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.PartyDetailAltID PartyDetailAltID
                        {
                            get
                            {
                                QuickFix.Fields.PartyDetailAltID val = new QuickFix.Fields.PartyDetailAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.PartyDetailAltID val)
                        {
                            this.PartyDetailAltID = val;
                        }

                        public QuickFix.Fields.PartyDetailAltID Get(QuickFix.Fields.PartyDetailAltID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.PartyDetailAltID val)
                        {
                            return IsSetPartyDetailAltID();
                        }

                        public bool IsSetPartyDetailAltID()
                        {
                            return IsSetField(Tags.PartyDetailAltID);
                        }
                        public QuickFix.Fields.PartyDetailAltIDSource PartyDetailAltIDSource
                        {
                            get
                            {
                                QuickFix.Fields.PartyDetailAltIDSource val = new QuickFix.Fields.PartyDetailAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.PartyDetailAltIDSource val)
                        {
                            this.PartyDetailAltIDSource = val;
                        }

                        public QuickFix.Fields.PartyDetailAltIDSource Get(QuickFix.Fields.PartyDetailAltIDSource val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.PartyDetailAltIDSource val)
                        {
                            return IsSetPartyDetailAltIDSource();
                        }

                        public bool IsSetPartyDetailAltIDSource()
                        {
                            return IsSetField(Tags.PartyDetailAltIDSource);
                        }
                        public QuickFix.Fields.NoPartyDetailAltSubIDs NoPartyDetailAltSubIDs
                        {
                            get
                            {
                                QuickFix.Fields.NoPartyDetailAltSubIDs val = new QuickFix.Fields.NoPartyDetailAltSubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.NoPartyDetailAltSubIDs val)
                        {
                            this.NoPartyDetailAltSubIDs = val;
                        }

                        public QuickFix.Fields.NoPartyDetailAltSubIDs Get(QuickFix.Fields.NoPartyDetailAltSubIDs val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.NoPartyDetailAltSubIDs val)
                        {
                            return IsSetNoPartyDetailAltSubIDs();
                        }

                        public bool IsSetNoPartyDetailAltSubIDs()
                        {
                            return IsSetField(Tags.NoPartyDetailAltSubIDs);
                        }
                        public class NoPartyDetailAltSubIDsGroup : Group
                        {
                            public static int[] fieldOrder = { Tags.PartyDetailAltSubID, Tags.PartyDetailAltSubIDType, 0 };

                            public NoPartyDetailAltSubIDsGroup()
                              : base(Tags.NoPartyDetailAltSubIDs, Tags.PartyDetailAltSubID, fieldOrder)
                            {
                            }

                            public override Group Clone()
                            {
                                var clone = new NoPartyDetailAltSubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }

                            public QuickFix.Fields.PartyDetailAltSubID PartyDetailAltSubID
                            {
                                get
                                {
                                    QuickFix.Fields.PartyDetailAltSubID val = new QuickFix.Fields.PartyDetailAltSubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.PartyDetailAltSubID val)
                            {
                                this.PartyDetailAltSubID = val;
                            }

                            public QuickFix.Fields.PartyDetailAltSubID Get(QuickFix.Fields.PartyDetailAltSubID val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.PartyDetailAltSubID val)
                            {
                                return IsSetPartyDetailAltSubID();
                            }

                            public bool IsSetPartyDetailAltSubID()
                            {
                                return IsSetField(Tags.PartyDetailAltSubID);
                            }
                            public QuickFix.Fields.PartyDetailAltSubIDType PartyDetailAltSubIDType
                            {
                                get
                                {
                                    QuickFix.Fields.PartyDetailAltSubIDType val = new QuickFix.Fields.PartyDetailAltSubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.PartyDetailAltSubIDType val)
                            {
                                this.PartyDetailAltSubIDType = val;
                            }

                            public QuickFix.Fields.PartyDetailAltSubIDType Get(QuickFix.Fields.PartyDetailAltSubIDType val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.PartyDetailAltSubIDType val)
                            {
                                return IsSetPartyDetailAltSubIDType();
                            }

                            public bool IsSetPartyDetailAltSubIDType()
                            {
                                return IsSetField(Tags.PartyDetailAltSubIDType);
                            }

                        }
                    }
                    public class NoRelatedPartyDetailIDGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.RelatedPartyDetailID, Tags.RelatedPartyDetailIDSource, Tags.RelatedPartyDetailRole, Tags.RelatedPartyDetailRoleQualifier, Tags.NoRelatedPartyDetailSubIDs, Tags.NoRelatedPartyDetailAltID, Tags.NoPartyRelationships, 0 };

                        public NoRelatedPartyDetailIDGroup()
                          : base(Tags.NoRelatedPartyDetailID, Tags.RelatedPartyDetailID, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoRelatedPartyDetailIDGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.RelatedPartyDetailID RelatedPartyDetailID
                        {
                            get
                            {
                                QuickFix.Fields.RelatedPartyDetailID val = new QuickFix.Fields.RelatedPartyDetailID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RelatedPartyDetailID val)
                        {
                            this.RelatedPartyDetailID = val;
                        }

                        public QuickFix.Fields.RelatedPartyDetailID Get(QuickFix.Fields.RelatedPartyDetailID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RelatedPartyDetailID val)
                        {
                            return IsSetRelatedPartyDetailID();
                        }

                        public bool IsSetRelatedPartyDetailID()
                        {
                            return IsSetField(Tags.RelatedPartyDetailID);
                        }
                        public QuickFix.Fields.RelatedPartyDetailIDSource RelatedPartyDetailIDSource
                        {
                            get
                            {
                                QuickFix.Fields.RelatedPartyDetailIDSource val = new QuickFix.Fields.RelatedPartyDetailIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RelatedPartyDetailIDSource val)
                        {
                            this.RelatedPartyDetailIDSource = val;
                        }

                        public QuickFix.Fields.RelatedPartyDetailIDSource Get(QuickFix.Fields.RelatedPartyDetailIDSource val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RelatedPartyDetailIDSource val)
                        {
                            return IsSetRelatedPartyDetailIDSource();
                        }

                        public bool IsSetRelatedPartyDetailIDSource()
                        {
                            return IsSetField(Tags.RelatedPartyDetailIDSource);
                        }
                        public QuickFix.Fields.RelatedPartyDetailRole RelatedPartyDetailRole
                        {
                            get
                            {
                                QuickFix.Fields.RelatedPartyDetailRole val = new QuickFix.Fields.RelatedPartyDetailRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RelatedPartyDetailRole val)
                        {
                            this.RelatedPartyDetailRole = val;
                        }

                        public QuickFix.Fields.RelatedPartyDetailRole Get(QuickFix.Fields.RelatedPartyDetailRole val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RelatedPartyDetailRole val)
                        {
                            return IsSetRelatedPartyDetailRole();
                        }

                        public bool IsSetRelatedPartyDetailRole()
                        {
                            return IsSetField(Tags.RelatedPartyDetailRole);
                        }
                        public QuickFix.Fields.RelatedPartyDetailRoleQualifier RelatedPartyDetailRoleQualifier
                        {
                            get
                            {
                                QuickFix.Fields.RelatedPartyDetailRoleQualifier val = new QuickFix.Fields.RelatedPartyDetailRoleQualifier();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RelatedPartyDetailRoleQualifier val)
                        {
                            this.RelatedPartyDetailRoleQualifier = val;
                        }

                        public QuickFix.Fields.RelatedPartyDetailRoleQualifier Get(QuickFix.Fields.RelatedPartyDetailRoleQualifier val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RelatedPartyDetailRoleQualifier val)
                        {
                            return IsSetRelatedPartyDetailRoleQualifier();
                        }

                        public bool IsSetRelatedPartyDetailRoleQualifier()
                        {
                            return IsSetField(Tags.RelatedPartyDetailRoleQualifier);
                        }
                        public QuickFix.Fields.NoRelatedPartyDetailSubIDs NoRelatedPartyDetailSubIDs
                        {
                            get
                            {
                                QuickFix.Fields.NoRelatedPartyDetailSubIDs val = new QuickFix.Fields.NoRelatedPartyDetailSubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.NoRelatedPartyDetailSubIDs val)
                        {
                            this.NoRelatedPartyDetailSubIDs = val;
                        }

                        public QuickFix.Fields.NoRelatedPartyDetailSubIDs Get(QuickFix.Fields.NoRelatedPartyDetailSubIDs val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailSubIDs val)
                        {
                            return IsSetNoRelatedPartyDetailSubIDs();
                        }

                        public bool IsSetNoRelatedPartyDetailSubIDs()
                        {
                            return IsSetField(Tags.NoRelatedPartyDetailSubIDs);
                        }
                        public QuickFix.Fields.NoRelatedPartyDetailAltID NoRelatedPartyDetailAltID
                        {
                            get
                            {
                                QuickFix.Fields.NoRelatedPartyDetailAltID val = new QuickFix.Fields.NoRelatedPartyDetailAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.NoRelatedPartyDetailAltID val)
                        {
                            this.NoRelatedPartyDetailAltID = val;
                        }

                        public QuickFix.Fields.NoRelatedPartyDetailAltID Get(QuickFix.Fields.NoRelatedPartyDetailAltID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailAltID val)
                        {
                            return IsSetNoRelatedPartyDetailAltID();
                        }

                        public bool IsSetNoRelatedPartyDetailAltID()
                        {
                            return IsSetField(Tags.NoRelatedPartyDetailAltID);
                        }
                        public QuickFix.Fields.NoPartyRelationships NoPartyRelationships
                        {
                            get
                            {
                                QuickFix.Fields.NoPartyRelationships val = new QuickFix.Fields.NoPartyRelationships();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.NoPartyRelationships val)
                        {
                            this.NoPartyRelationships = val;
                        }

                        public QuickFix.Fields.NoPartyRelationships Get(QuickFix.Fields.NoPartyRelationships val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.NoPartyRelationships val)
                        {
                            return IsSetNoPartyRelationships();
                        }

                        public bool IsSetNoPartyRelationships()
                        {
                            return IsSetField(Tags.NoPartyRelationships);
                        }
                        public class NoRelatedPartyDetailSubIDsGroup : Group
                        {
                            public static int[] fieldOrder = { Tags.RelatedPartyDetailSubID, Tags.RelatedPartyDetailSubIDType, 0 };

                            public NoRelatedPartyDetailSubIDsGroup()
                              : base(Tags.NoRelatedPartyDetailSubIDs, Tags.RelatedPartyDetailSubID, fieldOrder)
                            {
                            }

                            public override Group Clone()
                            {
                                var clone = new NoRelatedPartyDetailSubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }

                            public QuickFix.Fields.RelatedPartyDetailSubID RelatedPartyDetailSubID
                            {
                                get
                                {
                                    QuickFix.Fields.RelatedPartyDetailSubID val = new QuickFix.Fields.RelatedPartyDetailSubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RelatedPartyDetailSubID val)
                            {
                                this.RelatedPartyDetailSubID = val;
                            }

                            public QuickFix.Fields.RelatedPartyDetailSubID Get(QuickFix.Fields.RelatedPartyDetailSubID val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RelatedPartyDetailSubID val)
                            {
                                return IsSetRelatedPartyDetailSubID();
                            }

                            public bool IsSetRelatedPartyDetailSubID()
                            {
                                return IsSetField(Tags.RelatedPartyDetailSubID);
                            }
                            public QuickFix.Fields.RelatedPartyDetailSubIDType RelatedPartyDetailSubIDType
                            {
                                get
                                {
                                    QuickFix.Fields.RelatedPartyDetailSubIDType val = new QuickFix.Fields.RelatedPartyDetailSubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RelatedPartyDetailSubIDType val)
                            {
                                this.RelatedPartyDetailSubIDType = val;
                            }

                            public QuickFix.Fields.RelatedPartyDetailSubIDType Get(QuickFix.Fields.RelatedPartyDetailSubIDType val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RelatedPartyDetailSubIDType val)
                            {
                                return IsSetRelatedPartyDetailSubIDType();
                            }

                            public bool IsSetRelatedPartyDetailSubIDType()
                            {
                                return IsSetField(Tags.RelatedPartyDetailSubIDType);
                            }

                        }
                        public class NoRelatedPartyDetailAltIDGroup : Group
                        {
                            public static int[] fieldOrder = { Tags.RelatedPartyDetailAltID, Tags.RelatedPartyDetailAltIDSource, Tags.NoRelatedPartyDetailAltSubIDs, 0 };

                            public NoRelatedPartyDetailAltIDGroup()
                              : base(Tags.NoRelatedPartyDetailAltID, Tags.RelatedPartyDetailAltID, fieldOrder)
                            {
                            }

                            public override Group Clone()
                            {
                                var clone = new NoRelatedPartyDetailAltIDGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }

                            public QuickFix.Fields.RelatedPartyDetailAltID RelatedPartyDetailAltID
                            {
                                get
                                {
                                    QuickFix.Fields.RelatedPartyDetailAltID val = new QuickFix.Fields.RelatedPartyDetailAltID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RelatedPartyDetailAltID val)
                            {
                                this.RelatedPartyDetailAltID = val;
                            }

                            public QuickFix.Fields.RelatedPartyDetailAltID Get(QuickFix.Fields.RelatedPartyDetailAltID val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltID val)
                            {
                                return IsSetRelatedPartyDetailAltID();
                            }

                            public bool IsSetRelatedPartyDetailAltID()
                            {
                                return IsSetField(Tags.RelatedPartyDetailAltID);
                            }
                            public QuickFix.Fields.RelatedPartyDetailAltIDSource RelatedPartyDetailAltIDSource
                            {
                                get
                                {
                                    QuickFix.Fields.RelatedPartyDetailAltIDSource val = new QuickFix.Fields.RelatedPartyDetailAltIDSource();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RelatedPartyDetailAltIDSource val)
                            {
                                this.RelatedPartyDetailAltIDSource = val;
                            }

                            public QuickFix.Fields.RelatedPartyDetailAltIDSource Get(QuickFix.Fields.RelatedPartyDetailAltIDSource val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltIDSource val)
                            {
                                return IsSetRelatedPartyDetailAltIDSource();
                            }

                            public bool IsSetRelatedPartyDetailAltIDSource()
                            {
                                return IsSetField(Tags.RelatedPartyDetailAltIDSource);
                            }
                            public QuickFix.Fields.NoRelatedPartyDetailAltSubIDs NoRelatedPartyDetailAltSubIDs
                            {
                                get
                                {
                                    QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val = new QuickFix.Fields.NoRelatedPartyDetailAltSubIDs();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val)
                            {
                                this.NoRelatedPartyDetailAltSubIDs = val;
                            }

                            public QuickFix.Fields.NoRelatedPartyDetailAltSubIDs Get(QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val)
                            {
                                return IsSetNoRelatedPartyDetailAltSubIDs();
                            }

                            public bool IsSetNoRelatedPartyDetailAltSubIDs()
                            {
                                return IsSetField(Tags.NoRelatedPartyDetailAltSubIDs);
                            }
                            public class NoRelatedPartyDetailAltSubIDsGroup : Group
                            {
                                public static int[] fieldOrder = { Tags.RelatedPartyDetailAltSubID, Tags.RelatedPartyDetailAltSubIDType, 0 };

                                public NoRelatedPartyDetailAltSubIDsGroup()
                                  : base(Tags.NoRelatedPartyDetailAltSubIDs, Tags.RelatedPartyDetailAltSubID, fieldOrder)
                                {
                                }

                                public override Group Clone()
                                {
                                    var clone = new NoRelatedPartyDetailAltSubIDsGroup();
                                    clone.CopyStateFrom(this);
                                    return clone;
                                }

                                public QuickFix.Fields.RelatedPartyDetailAltSubID RelatedPartyDetailAltSubID
                                {
                                    get
                                    {
                                        QuickFix.Fields.RelatedPartyDetailAltSubID val = new QuickFix.Fields.RelatedPartyDetailAltSubID();
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }

                                public void Set(QuickFix.Fields.RelatedPartyDetailAltSubID val)
                                {
                                    this.RelatedPartyDetailAltSubID = val;
                                }

                                public QuickFix.Fields.RelatedPartyDetailAltSubID Get(QuickFix.Fields.RelatedPartyDetailAltSubID val)
                                {
                                    GetField(val);
                                    return val;
                                }

                                public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltSubID val)
                                {
                                    return IsSetRelatedPartyDetailAltSubID();
                                }

                                public bool IsSetRelatedPartyDetailAltSubID()
                                {
                                    return IsSetField(Tags.RelatedPartyDetailAltSubID);
                                }
                                public QuickFix.Fields.RelatedPartyDetailAltSubIDType RelatedPartyDetailAltSubIDType
                                {
                                    get
                                    {
                                        QuickFix.Fields.RelatedPartyDetailAltSubIDType val = new QuickFix.Fields.RelatedPartyDetailAltSubIDType();
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }

                                public void Set(QuickFix.Fields.RelatedPartyDetailAltSubIDType val)
                                {
                                    this.RelatedPartyDetailAltSubIDType = val;
                                }

                                public QuickFix.Fields.RelatedPartyDetailAltSubIDType Get(QuickFix.Fields.RelatedPartyDetailAltSubIDType val)
                                {
                                    GetField(val);
                                    return val;
                                }

                                public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltSubIDType val)
                                {
                                    return IsSetRelatedPartyDetailAltSubIDType();
                                }

                                public bool IsSetRelatedPartyDetailAltSubIDType()
                                {
                                    return IsSetField(Tags.RelatedPartyDetailAltSubIDType);
                                }

                            }
                        }
                        public class NoPartyRelationshipsGroup : Group
                        {
                            public static int[] fieldOrder = { Tags.PartyRelationship, 0 };

                            public NoPartyRelationshipsGroup()
                              : base(Tags.NoPartyRelationships, Tags.PartyRelationship, fieldOrder)
                            {
                            }

                            public override Group Clone()
                            {
                                var clone = new NoPartyRelationshipsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }

                            public QuickFix.Fields.PartyRelationship PartyRelationship
                            {
                                get
                                {
                                    QuickFix.Fields.PartyRelationship val = new QuickFix.Fields.PartyRelationship();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.PartyRelationship val)
                            {
                                this.PartyRelationship = val;
                            }

                            public QuickFix.Fields.PartyRelationship Get(QuickFix.Fields.PartyRelationship val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.PartyRelationship val)
                            {
                                return IsSetPartyRelationship();
                            }

                            public bool IsSetPartyRelationship()
                            {
                                return IsSetField(Tags.PartyRelationship);
                            }

                        }
                    }
                }
                public class NoRiskLimitsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.NoRiskLimitTypes, Tags.NoRiskInstrumentScopes, 0 };

                    public NoRiskLimitsGroup()
                      : base(Tags.NoRiskLimits, Tags.NoRiskLimitTypes, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRiskLimitsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.NoRiskLimitTypes NoRiskLimitTypes
                    {
                        get
                        {
                            QuickFix.Fields.NoRiskLimitTypes val = new QuickFix.Fields.NoRiskLimitTypes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoRiskLimitTypes val)
                    {
                        this.NoRiskLimitTypes = val;
                    }

                    public QuickFix.Fields.NoRiskLimitTypes Get(QuickFix.Fields.NoRiskLimitTypes val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoRiskLimitTypes val)
                    {
                        return IsSetNoRiskLimitTypes();
                    }

                    public bool IsSetNoRiskLimitTypes()
                    {
                        return IsSetField(Tags.NoRiskLimitTypes);
                    }
                    public QuickFix.Fields.NoRiskInstrumentScopes NoRiskInstrumentScopes
                    {
                        get
                        {
                            QuickFix.Fields.NoRiskInstrumentScopes val = new QuickFix.Fields.NoRiskInstrumentScopes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoRiskInstrumentScopes val)
                    {
                        this.NoRiskInstrumentScopes = val;
                    }

                    public QuickFix.Fields.NoRiskInstrumentScopes Get(QuickFix.Fields.NoRiskInstrumentScopes val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoRiskInstrumentScopes val)
                    {
                        return IsSetNoRiskInstrumentScopes();
                    }

                    public bool IsSetNoRiskInstrumentScopes()
                    {
                        return IsSetField(Tags.NoRiskInstrumentScopes);
                    }
                    public class NoRiskLimitTypesGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.RiskLimitType, Tags.RiskLimitAmount, Tags.RiskLimitCurrency, Tags.RiskLimitPlatform, Tags.NoRiskWarningLevels, Tags.RiskLimitAction, Tags.RiskLimitUtilizationAmount, Tags.RiskLimitUtilizationPercent, Tags.RiskLimitVelocityPeriod, Tags.RiskLimitVelocityUnit, 0 };

                        public NoRiskLimitTypesGroup()
                          : base(Tags.NoRiskLimitTypes, Tags.RiskLimitType, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoRiskLimitTypesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.RiskLimitType RiskLimitType
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitType val = new QuickFix.Fields.RiskLimitType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitType val)
                        {
                            this.RiskLimitType = val;
                        }

                        public QuickFix.Fields.RiskLimitType Get(QuickFix.Fields.RiskLimitType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitType val)
                        {
                            return IsSetRiskLimitType();
                        }

                        public bool IsSetRiskLimitType()
                        {
                            return IsSetField(Tags.RiskLimitType);
                        }
                        public QuickFix.Fields.RiskLimitAmount RiskLimitAmount
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitAmount val = new QuickFix.Fields.RiskLimitAmount();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitAmount val)
                        {
                            this.RiskLimitAmount = val;
                        }

                        public QuickFix.Fields.RiskLimitAmount Get(QuickFix.Fields.RiskLimitAmount val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitAmount val)
                        {
                            return IsSetRiskLimitAmount();
                        }

                        public bool IsSetRiskLimitAmount()
                        {
                            return IsSetField(Tags.RiskLimitAmount);
                        }
                        public QuickFix.Fields.RiskLimitCurrency RiskLimitCurrency
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitCurrency val = new QuickFix.Fields.RiskLimitCurrency();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitCurrency val)
                        {
                            this.RiskLimitCurrency = val;
                        }

                        public QuickFix.Fields.RiskLimitCurrency Get(QuickFix.Fields.RiskLimitCurrency val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitCurrency val)
                        {
                            return IsSetRiskLimitCurrency();
                        }

                        public bool IsSetRiskLimitCurrency()
                        {
                            return IsSetField(Tags.RiskLimitCurrency);
                        }
                        public QuickFix.Fields.RiskLimitPlatform RiskLimitPlatform
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitPlatform val = new QuickFix.Fields.RiskLimitPlatform();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitPlatform val)
                        {
                            this.RiskLimitPlatform = val;
                        }

                        public QuickFix.Fields.RiskLimitPlatform Get(QuickFix.Fields.RiskLimitPlatform val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitPlatform val)
                        {
                            return IsSetRiskLimitPlatform();
                        }

                        public bool IsSetRiskLimitPlatform()
                        {
                            return IsSetField(Tags.RiskLimitPlatform);
                        }
                        public QuickFix.Fields.NoRiskWarningLevels NoRiskWarningLevels
                        {
                            get
                            {
                                QuickFix.Fields.NoRiskWarningLevels val = new QuickFix.Fields.NoRiskWarningLevels();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.NoRiskWarningLevels val)
                        {
                            this.NoRiskWarningLevels = val;
                        }

                        public QuickFix.Fields.NoRiskWarningLevels Get(QuickFix.Fields.NoRiskWarningLevels val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.NoRiskWarningLevels val)
                        {
                            return IsSetNoRiskWarningLevels();
                        }

                        public bool IsSetNoRiskWarningLevels()
                        {
                            return IsSetField(Tags.NoRiskWarningLevels);
                        }
                        public QuickFix.Fields.RiskLimitAction RiskLimitAction
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitAction val = new QuickFix.Fields.RiskLimitAction();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitAction val)
                        {
                            this.RiskLimitAction = val;
                        }

                        public QuickFix.Fields.RiskLimitAction Get(QuickFix.Fields.RiskLimitAction val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitAction val)
                        {
                            return IsSetRiskLimitAction();
                        }

                        public bool IsSetRiskLimitAction()
                        {
                            return IsSetField(Tags.RiskLimitAction);
                        }
                        public QuickFix.Fields.RiskLimitUtilizationAmount RiskLimitUtilizationAmount
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitUtilizationAmount val = new QuickFix.Fields.RiskLimitUtilizationAmount();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitUtilizationAmount val)
                        {
                            this.RiskLimitUtilizationAmount = val;
                        }

                        public QuickFix.Fields.RiskLimitUtilizationAmount Get(QuickFix.Fields.RiskLimitUtilizationAmount val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitUtilizationAmount val)
                        {
                            return IsSetRiskLimitUtilizationAmount();
                        }

                        public bool IsSetRiskLimitUtilizationAmount()
                        {
                            return IsSetField(Tags.RiskLimitUtilizationAmount);
                        }
                        public QuickFix.Fields.RiskLimitUtilizationPercent RiskLimitUtilizationPercent
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitUtilizationPercent val = new QuickFix.Fields.RiskLimitUtilizationPercent();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitUtilizationPercent val)
                        {
                            this.RiskLimitUtilizationPercent = val;
                        }

                        public QuickFix.Fields.RiskLimitUtilizationPercent Get(QuickFix.Fields.RiskLimitUtilizationPercent val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitUtilizationPercent val)
                        {
                            return IsSetRiskLimitUtilizationPercent();
                        }

                        public bool IsSetRiskLimitUtilizationPercent()
                        {
                            return IsSetField(Tags.RiskLimitUtilizationPercent);
                        }
                        public QuickFix.Fields.RiskLimitVelocityPeriod RiskLimitVelocityPeriod
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitVelocityPeriod val = new QuickFix.Fields.RiskLimitVelocityPeriod();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitVelocityPeriod val)
                        {
                            this.RiskLimitVelocityPeriod = val;
                        }

                        public QuickFix.Fields.RiskLimitVelocityPeriod Get(QuickFix.Fields.RiskLimitVelocityPeriod val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitVelocityPeriod val)
                        {
                            return IsSetRiskLimitVelocityPeriod();
                        }

                        public bool IsSetRiskLimitVelocityPeriod()
                        {
                            return IsSetField(Tags.RiskLimitVelocityPeriod);
                        }
                        public QuickFix.Fields.RiskLimitVelocityUnit RiskLimitVelocityUnit
                        {
                            get
                            {
                                QuickFix.Fields.RiskLimitVelocityUnit val = new QuickFix.Fields.RiskLimitVelocityUnit();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskLimitVelocityUnit val)
                        {
                            this.RiskLimitVelocityUnit = val;
                        }

                        public QuickFix.Fields.RiskLimitVelocityUnit Get(QuickFix.Fields.RiskLimitVelocityUnit val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskLimitVelocityUnit val)
                        {
                            return IsSetRiskLimitVelocityUnit();
                        }

                        public bool IsSetRiskLimitVelocityUnit()
                        {
                            return IsSetField(Tags.RiskLimitVelocityUnit);
                        }
                        public class NoRiskWarningLevelsGroup : Group
                        {
                            public static int[] fieldOrder = { Tags.RiskWarningLevelPercent, Tags.RiskWarningLevelName, Tags.RiskWarningLevelAmount, Tags.RiskWarningLevelAction, 0 };

                            public NoRiskWarningLevelsGroup()
                              : base(Tags.NoRiskWarningLevels, Tags.RiskWarningLevelPercent, fieldOrder)
                            {
                            }

                            public override Group Clone()
                            {
                                var clone = new NoRiskWarningLevelsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }

                            public QuickFix.Fields.RiskWarningLevelPercent RiskWarningLevelPercent
                            {
                                get
                                {
                                    QuickFix.Fields.RiskWarningLevelPercent val = new QuickFix.Fields.RiskWarningLevelPercent();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RiskWarningLevelPercent val)
                            {
                                this.RiskWarningLevelPercent = val;
                            }

                            public QuickFix.Fields.RiskWarningLevelPercent Get(QuickFix.Fields.RiskWarningLevelPercent val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RiskWarningLevelPercent val)
                            {
                                return IsSetRiskWarningLevelPercent();
                            }

                            public bool IsSetRiskWarningLevelPercent()
                            {
                                return IsSetField(Tags.RiskWarningLevelPercent);
                            }
                            public QuickFix.Fields.RiskWarningLevelName RiskWarningLevelName
                            {
                                get
                                {
                                    QuickFix.Fields.RiskWarningLevelName val = new QuickFix.Fields.RiskWarningLevelName();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RiskWarningLevelName val)
                            {
                                this.RiskWarningLevelName = val;
                            }

                            public QuickFix.Fields.RiskWarningLevelName Get(QuickFix.Fields.RiskWarningLevelName val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RiskWarningLevelName val)
                            {
                                return IsSetRiskWarningLevelName();
                            }

                            public bool IsSetRiskWarningLevelName()
                            {
                                return IsSetField(Tags.RiskWarningLevelName);
                            }
                            public QuickFix.Fields.RiskWarningLevelAmount RiskWarningLevelAmount
                            {
                                get
                                {
                                    QuickFix.Fields.RiskWarningLevelAmount val = new QuickFix.Fields.RiskWarningLevelAmount();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RiskWarningLevelAmount val)
                            {
                                this.RiskWarningLevelAmount = val;
                            }

                            public QuickFix.Fields.RiskWarningLevelAmount Get(QuickFix.Fields.RiskWarningLevelAmount val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RiskWarningLevelAmount val)
                            {
                                return IsSetRiskWarningLevelAmount();
                            }

                            public bool IsSetRiskWarningLevelAmount()
                            {
                                return IsSetField(Tags.RiskWarningLevelAmount);
                            }
                            public QuickFix.Fields.RiskWarningLevelAction RiskWarningLevelAction
                            {
                                get
                                {
                                    QuickFix.Fields.RiskWarningLevelAction val = new QuickFix.Fields.RiskWarningLevelAction();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.RiskWarningLevelAction val)
                            {
                                this.RiskWarningLevelAction = val;
                            }

                            public QuickFix.Fields.RiskWarningLevelAction Get(QuickFix.Fields.RiskWarningLevelAction val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.RiskWarningLevelAction val)
                            {
                                return IsSetRiskWarningLevelAction();
                            }

                            public bool IsSetRiskWarningLevelAction()
                            {
                                return IsSetField(Tags.RiskWarningLevelAction);
                            }

                        }
                    }
                    public class NoRiskInstrumentScopesGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.InstrumentScopeOperator, Tags.InstrumentScopeSymbol, Tags.InstrumentScopeSymbolSfx, Tags.InstrumentScopeSecurityID, Tags.InstrumentScopeSecurityIDSource, Tags.NoInstrumentScopeSecurityAltID, Tags.InstrumentScopeProduct, Tags.InstrumentScopeProductComplex, Tags.InstrumentScopeSecurityGroup, Tags.InstrumentScopeCFICode, Tags.InstrumentScopeSecurityType, Tags.InstrumentScopeSecuritySubType, Tags.InstrumentScopeMaturityMonthYear, Tags.InstrumentScopeMaturityTime, Tags.InstrumentScopeRestructuringType, Tags.InstrumentScopeSeniority, Tags.InstrumentScopePutOrCall, Tags.InstrumentScopeFlexibleIndicator, Tags.InstrumentScopeCouponRate, Tags.InstrumentScopeSecurityExchange, Tags.InstrumentScopeSecurityDesc, Tags.InstrumentScopeEncodedSecurityDescLen, Tags.InstrumentScopeEncodedSecurityDesc, Tags.InstrumentScopeSettlType, Tags.InstrumentScopeUPICode, Tags.RiskInstrumentMultiplier, 0 };

                        public NoRiskInstrumentScopesGroup()
                          : base(Tags.NoRiskInstrumentScopes, Tags.InstrumentScopeOperator, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoRiskInstrumentScopesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.InstrumentScopeOperator InstrumentScopeOperator
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeOperator val = new QuickFix.Fields.InstrumentScopeOperator();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeOperator val)
                        {
                            this.InstrumentScopeOperator = val;
                        }

                        public QuickFix.Fields.InstrumentScopeOperator Get(QuickFix.Fields.InstrumentScopeOperator val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeOperator val)
                        {
                            return IsSetInstrumentScopeOperator();
                        }

                        public bool IsSetInstrumentScopeOperator()
                        {
                            return IsSetField(Tags.InstrumentScopeOperator);
                        }
                        public QuickFix.Fields.InstrumentScopeSymbol InstrumentScopeSymbol
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSymbol val = new QuickFix.Fields.InstrumentScopeSymbol();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSymbol val)
                        {
                            this.InstrumentScopeSymbol = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSymbol Get(QuickFix.Fields.InstrumentScopeSymbol val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSymbol val)
                        {
                            return IsSetInstrumentScopeSymbol();
                        }

                        public bool IsSetInstrumentScopeSymbol()
                        {
                            return IsSetField(Tags.InstrumentScopeSymbol);
                        }
                        public QuickFix.Fields.InstrumentScopeSymbolSfx InstrumentScopeSymbolSfx
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSymbolSfx val = new QuickFix.Fields.InstrumentScopeSymbolSfx();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSymbolSfx val)
                        {
                            this.InstrumentScopeSymbolSfx = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSymbolSfx Get(QuickFix.Fields.InstrumentScopeSymbolSfx val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSymbolSfx val)
                        {
                            return IsSetInstrumentScopeSymbolSfx();
                        }

                        public bool IsSetInstrumentScopeSymbolSfx()
                        {
                            return IsSetField(Tags.InstrumentScopeSymbolSfx);
                        }
                        public QuickFix.Fields.InstrumentScopeSecurityID InstrumentScopeSecurityID
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSecurityID val = new QuickFix.Fields.InstrumentScopeSecurityID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSecurityID val)
                        {
                            this.InstrumentScopeSecurityID = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSecurityID Get(QuickFix.Fields.InstrumentScopeSecurityID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityID val)
                        {
                            return IsSetInstrumentScopeSecurityID();
                        }

                        public bool IsSetInstrumentScopeSecurityID()
                        {
                            return IsSetField(Tags.InstrumentScopeSecurityID);
                        }
                        public QuickFix.Fields.InstrumentScopeSecurityIDSource InstrumentScopeSecurityIDSource
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSecurityIDSource val = new QuickFix.Fields.InstrumentScopeSecurityIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSecurityIDSource val)
                        {
                            this.InstrumentScopeSecurityIDSource = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSecurityIDSource Get(QuickFix.Fields.InstrumentScopeSecurityIDSource val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityIDSource val)
                        {
                            return IsSetInstrumentScopeSecurityIDSource();
                        }

                        public bool IsSetInstrumentScopeSecurityIDSource()
                        {
                            return IsSetField(Tags.InstrumentScopeSecurityIDSource);
                        }
                        public QuickFix.Fields.NoInstrumentScopeSecurityAltID NoInstrumentScopeSecurityAltID
                        {
                            get
                            {
                                QuickFix.Fields.NoInstrumentScopeSecurityAltID val = new QuickFix.Fields.NoInstrumentScopeSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.NoInstrumentScopeSecurityAltID val)
                        {
                            this.NoInstrumentScopeSecurityAltID = val;
                        }

                        public QuickFix.Fields.NoInstrumentScopeSecurityAltID Get(QuickFix.Fields.NoInstrumentScopeSecurityAltID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.NoInstrumentScopeSecurityAltID val)
                        {
                            return IsSetNoInstrumentScopeSecurityAltID();
                        }

                        public bool IsSetNoInstrumentScopeSecurityAltID()
                        {
                            return IsSetField(Tags.NoInstrumentScopeSecurityAltID);
                        }
                        public QuickFix.Fields.InstrumentScopeProduct InstrumentScopeProduct
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeProduct val = new QuickFix.Fields.InstrumentScopeProduct();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeProduct val)
                        {
                            this.InstrumentScopeProduct = val;
                        }

                        public QuickFix.Fields.InstrumentScopeProduct Get(QuickFix.Fields.InstrumentScopeProduct val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeProduct val)
                        {
                            return IsSetInstrumentScopeProduct();
                        }

                        public bool IsSetInstrumentScopeProduct()
                        {
                            return IsSetField(Tags.InstrumentScopeProduct);
                        }
                        public QuickFix.Fields.InstrumentScopeProductComplex InstrumentScopeProductComplex
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeProductComplex val = new QuickFix.Fields.InstrumentScopeProductComplex();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeProductComplex val)
                        {
                            this.InstrumentScopeProductComplex = val;
                        }

                        public QuickFix.Fields.InstrumentScopeProductComplex Get(QuickFix.Fields.InstrumentScopeProductComplex val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeProductComplex val)
                        {
                            return IsSetInstrumentScopeProductComplex();
                        }

                        public bool IsSetInstrumentScopeProductComplex()
                        {
                            return IsSetField(Tags.InstrumentScopeProductComplex);
                        }
                        public QuickFix.Fields.InstrumentScopeSecurityGroup InstrumentScopeSecurityGroup
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSecurityGroup val = new QuickFix.Fields.InstrumentScopeSecurityGroup();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSecurityGroup val)
                        {
                            this.InstrumentScopeSecurityGroup = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSecurityGroup Get(QuickFix.Fields.InstrumentScopeSecurityGroup val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityGroup val)
                        {
                            return IsSetInstrumentScopeSecurityGroup();
                        }

                        public bool IsSetInstrumentScopeSecurityGroup()
                        {
                            return IsSetField(Tags.InstrumentScopeSecurityGroup);
                        }
                        public QuickFix.Fields.InstrumentScopeCFICode InstrumentScopeCFICode
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeCFICode val = new QuickFix.Fields.InstrumentScopeCFICode();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeCFICode val)
                        {
                            this.InstrumentScopeCFICode = val;
                        }

                        public QuickFix.Fields.InstrumentScopeCFICode Get(QuickFix.Fields.InstrumentScopeCFICode val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeCFICode val)
                        {
                            return IsSetInstrumentScopeCFICode();
                        }

                        public bool IsSetInstrumentScopeCFICode()
                        {
                            return IsSetField(Tags.InstrumentScopeCFICode);
                        }
                        public QuickFix.Fields.InstrumentScopeSecurityType InstrumentScopeSecurityType
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSecurityType val = new QuickFix.Fields.InstrumentScopeSecurityType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSecurityType val)
                        {
                            this.InstrumentScopeSecurityType = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSecurityType Get(QuickFix.Fields.InstrumentScopeSecurityType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityType val)
                        {
                            return IsSetInstrumentScopeSecurityType();
                        }

                        public bool IsSetInstrumentScopeSecurityType()
                        {
                            return IsSetField(Tags.InstrumentScopeSecurityType);
                        }
                        public QuickFix.Fields.InstrumentScopeSecuritySubType InstrumentScopeSecuritySubType
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSecuritySubType val = new QuickFix.Fields.InstrumentScopeSecuritySubType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSecuritySubType val)
                        {
                            this.InstrumentScopeSecuritySubType = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSecuritySubType Get(QuickFix.Fields.InstrumentScopeSecuritySubType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSecuritySubType val)
                        {
                            return IsSetInstrumentScopeSecuritySubType();
                        }

                        public bool IsSetInstrumentScopeSecuritySubType()
                        {
                            return IsSetField(Tags.InstrumentScopeSecuritySubType);
                        }
                        public QuickFix.Fields.InstrumentScopeMaturityMonthYear InstrumentScopeMaturityMonthYear
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeMaturityMonthYear val = new QuickFix.Fields.InstrumentScopeMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeMaturityMonthYear val)
                        {
                            this.InstrumentScopeMaturityMonthYear = val;
                        }

                        public QuickFix.Fields.InstrumentScopeMaturityMonthYear Get(QuickFix.Fields.InstrumentScopeMaturityMonthYear val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeMaturityMonthYear val)
                        {
                            return IsSetInstrumentScopeMaturityMonthYear();
                        }

                        public bool IsSetInstrumentScopeMaturityMonthYear()
                        {
                            return IsSetField(Tags.InstrumentScopeMaturityMonthYear);
                        }
                        public QuickFix.Fields.InstrumentScopeMaturityTime InstrumentScopeMaturityTime
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeMaturityTime val = new QuickFix.Fields.InstrumentScopeMaturityTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeMaturityTime val)
                        {
                            this.InstrumentScopeMaturityTime = val;
                        }

                        public QuickFix.Fields.InstrumentScopeMaturityTime Get(QuickFix.Fields.InstrumentScopeMaturityTime val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeMaturityTime val)
                        {
                            return IsSetInstrumentScopeMaturityTime();
                        }

                        public bool IsSetInstrumentScopeMaturityTime()
                        {
                            return IsSetField(Tags.InstrumentScopeMaturityTime);
                        }
                        public QuickFix.Fields.InstrumentScopeRestructuringType InstrumentScopeRestructuringType
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeRestructuringType val = new QuickFix.Fields.InstrumentScopeRestructuringType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeRestructuringType val)
                        {
                            this.InstrumentScopeRestructuringType = val;
                        }

                        public QuickFix.Fields.InstrumentScopeRestructuringType Get(QuickFix.Fields.InstrumentScopeRestructuringType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeRestructuringType val)
                        {
                            return IsSetInstrumentScopeRestructuringType();
                        }

                        public bool IsSetInstrumentScopeRestructuringType()
                        {
                            return IsSetField(Tags.InstrumentScopeRestructuringType);
                        }
                        public QuickFix.Fields.InstrumentScopeSeniority InstrumentScopeSeniority
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSeniority val = new QuickFix.Fields.InstrumentScopeSeniority();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSeniority val)
                        {
                            this.InstrumentScopeSeniority = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSeniority Get(QuickFix.Fields.InstrumentScopeSeniority val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSeniority val)
                        {
                            return IsSetInstrumentScopeSeniority();
                        }

                        public bool IsSetInstrumentScopeSeniority()
                        {
                            return IsSetField(Tags.InstrumentScopeSeniority);
                        }
                        public QuickFix.Fields.InstrumentScopePutOrCall InstrumentScopePutOrCall
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopePutOrCall val = new QuickFix.Fields.InstrumentScopePutOrCall();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopePutOrCall val)
                        {
                            this.InstrumentScopePutOrCall = val;
                        }

                        public QuickFix.Fields.InstrumentScopePutOrCall Get(QuickFix.Fields.InstrumentScopePutOrCall val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopePutOrCall val)
                        {
                            return IsSetInstrumentScopePutOrCall();
                        }

                        public bool IsSetInstrumentScopePutOrCall()
                        {
                            return IsSetField(Tags.InstrumentScopePutOrCall);
                        }
                        public QuickFix.Fields.InstrumentScopeFlexibleIndicator InstrumentScopeFlexibleIndicator
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeFlexibleIndicator val = new QuickFix.Fields.InstrumentScopeFlexibleIndicator();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeFlexibleIndicator val)
                        {
                            this.InstrumentScopeFlexibleIndicator = val;
                        }

                        public QuickFix.Fields.InstrumentScopeFlexibleIndicator Get(QuickFix.Fields.InstrumentScopeFlexibleIndicator val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeFlexibleIndicator val)
                        {
                            return IsSetInstrumentScopeFlexibleIndicator();
                        }

                        public bool IsSetInstrumentScopeFlexibleIndicator()
                        {
                            return IsSetField(Tags.InstrumentScopeFlexibleIndicator);
                        }
                        public QuickFix.Fields.InstrumentScopeCouponRate InstrumentScopeCouponRate
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeCouponRate val = new QuickFix.Fields.InstrumentScopeCouponRate();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeCouponRate val)
                        {
                            this.InstrumentScopeCouponRate = val;
                        }

                        public QuickFix.Fields.InstrumentScopeCouponRate Get(QuickFix.Fields.InstrumentScopeCouponRate val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeCouponRate val)
                        {
                            return IsSetInstrumentScopeCouponRate();
                        }

                        public bool IsSetInstrumentScopeCouponRate()
                        {
                            return IsSetField(Tags.InstrumentScopeCouponRate);
                        }
                        public QuickFix.Fields.InstrumentScopeSecurityExchange InstrumentScopeSecurityExchange
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSecurityExchange val = new QuickFix.Fields.InstrumentScopeSecurityExchange();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSecurityExchange val)
                        {
                            this.InstrumentScopeSecurityExchange = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSecurityExchange Get(QuickFix.Fields.InstrumentScopeSecurityExchange val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityExchange val)
                        {
                            return IsSetInstrumentScopeSecurityExchange();
                        }

                        public bool IsSetInstrumentScopeSecurityExchange()
                        {
                            return IsSetField(Tags.InstrumentScopeSecurityExchange);
                        }
                        public QuickFix.Fields.InstrumentScopeSecurityDesc InstrumentScopeSecurityDesc
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSecurityDesc val = new QuickFix.Fields.InstrumentScopeSecurityDesc();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSecurityDesc val)
                        {
                            this.InstrumentScopeSecurityDesc = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSecurityDesc Get(QuickFix.Fields.InstrumentScopeSecurityDesc val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityDesc val)
                        {
                            return IsSetInstrumentScopeSecurityDesc();
                        }

                        public bool IsSetInstrumentScopeSecurityDesc()
                        {
                            return IsSetField(Tags.InstrumentScopeSecurityDesc);
                        }
                        public QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen InstrumentScopeEncodedSecurityDescLen
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val = new QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val)
                        {
                            this.InstrumentScopeEncodedSecurityDescLen = val;
                        }

                        public QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen Get(QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val)
                        {
                            return IsSetInstrumentScopeEncodedSecurityDescLen();
                        }

                        public bool IsSetInstrumentScopeEncodedSecurityDescLen()
                        {
                            return IsSetField(Tags.InstrumentScopeEncodedSecurityDescLen);
                        }
                        public QuickFix.Fields.InstrumentScopeEncodedSecurityDesc InstrumentScopeEncodedSecurityDesc
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val = new QuickFix.Fields.InstrumentScopeEncodedSecurityDesc();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val)
                        {
                            this.InstrumentScopeEncodedSecurityDesc = val;
                        }

                        public QuickFix.Fields.InstrumentScopeEncodedSecurityDesc Get(QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val)
                        {
                            return IsSetInstrumentScopeEncodedSecurityDesc();
                        }

                        public bool IsSetInstrumentScopeEncodedSecurityDesc()
                        {
                            return IsSetField(Tags.InstrumentScopeEncodedSecurityDesc);
                        }
                        public QuickFix.Fields.InstrumentScopeSettlType InstrumentScopeSettlType
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeSettlType val = new QuickFix.Fields.InstrumentScopeSettlType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeSettlType val)
                        {
                            this.InstrumentScopeSettlType = val;
                        }

                        public QuickFix.Fields.InstrumentScopeSettlType Get(QuickFix.Fields.InstrumentScopeSettlType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeSettlType val)
                        {
                            return IsSetInstrumentScopeSettlType();
                        }

                        public bool IsSetInstrumentScopeSettlType()
                        {
                            return IsSetField(Tags.InstrumentScopeSettlType);
                        }
                        public QuickFix.Fields.InstrumentScopeUPICode InstrumentScopeUPICode
                        {
                            get
                            {
                                QuickFix.Fields.InstrumentScopeUPICode val = new QuickFix.Fields.InstrumentScopeUPICode();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.InstrumentScopeUPICode val)
                        {
                            this.InstrumentScopeUPICode = val;
                        }

                        public QuickFix.Fields.InstrumentScopeUPICode Get(QuickFix.Fields.InstrumentScopeUPICode val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.InstrumentScopeUPICode val)
                        {
                            return IsSetInstrumentScopeUPICode();
                        }

                        public bool IsSetInstrumentScopeUPICode()
                        {
                            return IsSetField(Tags.InstrumentScopeUPICode);
                        }
                        public QuickFix.Fields.RiskInstrumentMultiplier RiskInstrumentMultiplier
                        {
                            get
                            {
                                QuickFix.Fields.RiskInstrumentMultiplier val = new QuickFix.Fields.RiskInstrumentMultiplier();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RiskInstrumentMultiplier val)
                        {
                            this.RiskInstrumentMultiplier = val;
                        }

                        public QuickFix.Fields.RiskInstrumentMultiplier Get(QuickFix.Fields.RiskInstrumentMultiplier val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RiskInstrumentMultiplier val)
                        {
                            return IsSetRiskInstrumentMultiplier();
                        }

                        public bool IsSetRiskInstrumentMultiplier()
                        {
                            return IsSetField(Tags.RiskInstrumentMultiplier);
                        }
                        public class NoInstrumentScopeSecurityAltIDGroup : Group
                        {
                            public static int[] fieldOrder = { Tags.InstrumentScopeSecurityAltID, Tags.InstrumentScopeSecurityAltIDSource, 0 };

                            public NoInstrumentScopeSecurityAltIDGroup()
                              : base(Tags.NoInstrumentScopeSecurityAltID, Tags.InstrumentScopeSecurityAltID, fieldOrder)
                            {
                            }

                            public override Group Clone()
                            {
                                var clone = new NoInstrumentScopeSecurityAltIDGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }

                            public QuickFix.Fields.InstrumentScopeSecurityAltID InstrumentScopeSecurityAltID
                            {
                                get
                                {
                                    QuickFix.Fields.InstrumentScopeSecurityAltID val = new QuickFix.Fields.InstrumentScopeSecurityAltID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.InstrumentScopeSecurityAltID val)
                            {
                                this.InstrumentScopeSecurityAltID = val;
                            }

                            public QuickFix.Fields.InstrumentScopeSecurityAltID Get(QuickFix.Fields.InstrumentScopeSecurityAltID val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityAltID val)
                            {
                                return IsSetInstrumentScopeSecurityAltID();
                            }

                            public bool IsSetInstrumentScopeSecurityAltID()
                            {
                                return IsSetField(Tags.InstrumentScopeSecurityAltID);
                            }
                            public QuickFix.Fields.InstrumentScopeSecurityAltIDSource InstrumentScopeSecurityAltIDSource
                            {
                                get
                                {
                                    QuickFix.Fields.InstrumentScopeSecurityAltIDSource val = new QuickFix.Fields.InstrumentScopeSecurityAltIDSource();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }

                            public void Set(QuickFix.Fields.InstrumentScopeSecurityAltIDSource val)
                            {
                                this.InstrumentScopeSecurityAltIDSource = val;
                            }

                            public QuickFix.Fields.InstrumentScopeSecurityAltIDSource Get(QuickFix.Fields.InstrumentScopeSecurityAltIDSource val)
                            {
                                GetField(val);
                                return val;
                            }

                            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityAltIDSource val)
                            {
                                return IsSetInstrumentScopeSecurityAltIDSource();
                            }

                            public bool IsSetInstrumentScopeSecurityAltIDSource()
                            {
                                return IsSetField(Tags.InstrumentScopeSecurityAltIDSource);
                            }

                        }
                    }
                }
            }
        }
    }
}
