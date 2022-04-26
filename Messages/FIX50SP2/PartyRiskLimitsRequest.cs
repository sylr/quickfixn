// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PartyRiskLimitsRequest : Message
        {
            public const string MsgType = "CL";

            public PartyRiskLimitsRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CL"));
            }

            public PartyRiskLimitsRequest(
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
            public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
            {
                get
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SubscriptionRequestType val)
            {
                this.SubscriptionRequestType = val;
            }

            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SubscriptionRequestType val)
            {
                return IsSetSubscriptionRequestType();
            }

            public bool IsSetSubscriptionRequestType()
            {
                return IsSetField(Tags.SubscriptionRequestType);
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
            public QuickFix.Fields.NoPartyIDs NoPartyIDs
            {
                get
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPartyIDs val)
            {
                this.NoPartyIDs = val;
            }

            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPartyIDs val)
            {
                return IsSetNoPartyIDs();
            }

            public bool IsSetNoPartyIDs()
            {
                return IsSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.NoRequestedPartyRoles NoRequestedPartyRoles
            {
                get
                {
                    QuickFix.Fields.NoRequestedPartyRoles val = new QuickFix.Fields.NoRequestedPartyRoles();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoRequestedPartyRoles val)
            {
                this.NoRequestedPartyRoles = val;
            }

            public QuickFix.Fields.NoRequestedPartyRoles Get(QuickFix.Fields.NoRequestedPartyRoles val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoRequestedPartyRoles val)
            {
                return IsSetNoRequestedPartyRoles();
            }

            public bool IsSetNoRequestedPartyRoles()
            {
                return IsSetField(Tags.NoRequestedPartyRoles);
            }
            public QuickFix.Fields.NoRequestedRiskLimitType NoRequestedRiskLimitType
            {
                get
                {
                    QuickFix.Fields.NoRequestedRiskLimitType val = new QuickFix.Fields.NoRequestedRiskLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoRequestedRiskLimitType val)
            {
                this.NoRequestedRiskLimitType = val;
            }

            public QuickFix.Fields.NoRequestedRiskLimitType Get(QuickFix.Fields.NoRequestedRiskLimitType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoRequestedRiskLimitType val)
            {
                return IsSetNoRequestedRiskLimitType();
            }

            public bool IsSetNoRequestedRiskLimitType()
            {
                return IsSetField(Tags.NoRequestedRiskLimitType);
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
            public QuickFix.Fields.RiskLimitRequestType RiskLimitRequestType
            {
                get
                {
                    QuickFix.Fields.RiskLimitRequestType val = new QuickFix.Fields.RiskLimitRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RiskLimitRequestType val)
            {
                this.RiskLimitRequestType = val;
            }

            public QuickFix.Fields.RiskLimitRequestType Get(QuickFix.Fields.RiskLimitRequestType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RiskLimitRequestType val)
            {
                return IsSetRiskLimitRequestType();
            }

            public bool IsSetRiskLimitRequestType()
            {
                return IsSetField(Tags.RiskLimitRequestType);
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
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = { Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, Tags.PartyRoleQualifier, 0 };

                public NoPartyIDsGroup()
                  : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.PartyID PartyID
                {
                    get
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyID val)
                {
                    this.PartyID = val;
                }

                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyID val)
                {
                    return IsSetPartyID();
                }

                public bool IsSetPartyID()
                {
                    return IsSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource PartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyIDSource val)
                {
                    this.PartyIDSource = val;
                }

                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyIDSource val)
                {
                    return IsSetPartyIDSource();
                }

                public bool IsSetPartyIDSource()
                {
                    return IsSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole PartyRole
                {
                    get
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRole val)
                {
                    this.PartyRole = val;
                }

                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRole val)
                {
                    return IsSetPartyRole();
                }

                public bool IsSetPartyRole()
                {
                    return IsSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoPartySubIDs val)
                {
                    this.NoPartySubIDs = val;
                }

                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoPartySubIDs val)
                {
                    return IsSetNoPartySubIDs();
                }

                public bool IsSetNoPartySubIDs()
                {
                    return IsSetField(Tags.NoPartySubIDs);
                }
                public QuickFix.Fields.PartyRoleQualifier PartyRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.PartyRoleQualifier val = new QuickFix.Fields.PartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRoleQualifier val)
                {
                    this.PartyRoleQualifier = val;
                }

                public QuickFix.Fields.PartyRoleQualifier Get(QuickFix.Fields.PartyRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRoleQualifier val)
                {
                    return IsSetPartyRoleQualifier();
                }

                public bool IsSetPartyRoleQualifier()
                {
                    return IsSetField(Tags.PartyRoleQualifier);
                }
                public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.PartySubID, Tags.PartySubIDType, 0 };

                    public NoPartySubIDsGroup()
                      : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.PartySubID PartySubID
                    {
                        get
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubID val)
                    {
                        this.PartySubID = val;
                    }

                    public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubID val)
                    {
                        return IsSetPartySubID();
                    }

                    public bool IsSetPartySubID()
                    {
                        return IsSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType PartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubIDType val)
                    {
                        this.PartySubIDType = val;
                    }

                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubIDType val)
                    {
                        return IsSetPartySubIDType();
                    }

                    public bool IsSetPartySubIDType()
                    {
                        return IsSetField(Tags.PartySubIDType);
                    }

                }
            }
            public class NoRequestedPartyRolesGroup : Group
            {
                public static int[] fieldOrder = { Tags.RequestedPartyRole, Tags.RequestedPartyRoleQualifier, 0 };

                public NoRequestedPartyRolesGroup()
                  : base(Tags.NoRequestedPartyRoles, Tags.RequestedPartyRole, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRequestedPartyRolesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.RequestedPartyRole RequestedPartyRole
                {
                    get
                    {
                        QuickFix.Fields.RequestedPartyRole val = new QuickFix.Fields.RequestedPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestedPartyRole val)
                {
                    this.RequestedPartyRole = val;
                }

                public QuickFix.Fields.RequestedPartyRole Get(QuickFix.Fields.RequestedPartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestedPartyRole val)
                {
                    return IsSetRequestedPartyRole();
                }

                public bool IsSetRequestedPartyRole()
                {
                    return IsSetField(Tags.RequestedPartyRole);
                }
                public QuickFix.Fields.RequestedPartyRoleQualifier RequestedPartyRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.RequestedPartyRoleQualifier val = new QuickFix.Fields.RequestedPartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestedPartyRoleQualifier val)
                {
                    this.RequestedPartyRoleQualifier = val;
                }

                public QuickFix.Fields.RequestedPartyRoleQualifier Get(QuickFix.Fields.RequestedPartyRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestedPartyRoleQualifier val)
                {
                    return IsSetRequestedPartyRoleQualifier();
                }

                public bool IsSetRequestedPartyRoleQualifier()
                {
                    return IsSetField(Tags.RequestedPartyRoleQualifier);
                }

            }
            public class NoRequestedRiskLimitTypeGroup : Group
            {
                public static int[] fieldOrder = { Tags.RiskLimitType, 0 };

                public NoRequestedRiskLimitTypeGroup()
                  : base(Tags.NoRequestedRiskLimitType, Tags.RiskLimitType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRequestedRiskLimitTypeGroup();
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
