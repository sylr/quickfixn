// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PartyDetailsListRequest : Message
        {
            public const string MsgType = "CF";

            public PartyDetailsListRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CF"));
            }

            public PartyDetailsListRequest(
                    QuickFix.Fields.PartyDetailsListRequestID aPartyDetailsListRequestID
                ) : this()
            {
                this.PartyDetailsListRequestID = aPartyDetailsListRequestID;
            }

            public QuickFix.Fields.PartyDetailsListRequestID PartyDetailsListRequestID
            {
                get
                {
                    QuickFix.Fields.PartyDetailsListRequestID val = new QuickFix.Fields.PartyDetailsListRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PartyDetailsListRequestID val)
            {
                this.PartyDetailsListRequestID = val;
            }

            public QuickFix.Fields.PartyDetailsListRequestID Get(QuickFix.Fields.PartyDetailsListRequestID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PartyDetailsListRequestID val)
            {
                return IsSetPartyDetailsListRequestID();
            }

            public bool IsSetPartyDetailsListRequestID()
            {
                return IsSetField(Tags.PartyDetailsListRequestID);
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
}
