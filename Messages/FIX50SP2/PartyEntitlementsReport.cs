// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PartyEntitlementsReport : Message
        {
            public const string MsgType = "CV";

            public PartyEntitlementsReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CV"));
            }

            public PartyEntitlementsReport(
                    QuickFix.Fields.EntitlementReportID aEntitlementReportID
                ) : this()
            {
                this.EntitlementReportID = aEntitlementReportID;
            }

            public QuickFix.Fields.ApplID ApplID
            {
                get
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplID val)
            {
                this.ApplID = val;
            }

            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplID val)
            {
                return IsSetApplID();
            }

            public bool IsSetApplID()
            {
                return IsSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
            {
                get
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplSeqNum val)
            {
                this.ApplSeqNum = val;
            }

            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplSeqNum val)
            {
                return IsSetApplSeqNum();
            }

            public bool IsSetApplSeqNum()
            {
                return IsSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
            {
                get
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplLastSeqNum val)
            {
                this.ApplLastSeqNum = val;
            }

            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val)
            {
                return IsSetApplLastSeqNum();
            }

            public bool IsSetApplLastSeqNum()
            {
                return IsSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
            {
                get
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplResendFlag val)
            {
                this.ApplResendFlag = val;
            }

            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplResendFlag val)
            {
                return IsSetApplResendFlag();
            }

            public bool IsSetApplResendFlag()
            {
                return IsSetField(Tags.ApplResendFlag);
            }
            public QuickFix.Fields.EntitlementReportID EntitlementReportID
            {
                get
                {
                    QuickFix.Fields.EntitlementReportID val = new QuickFix.Fields.EntitlementReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EntitlementReportID val)
            {
                this.EntitlementReportID = val;
            }

            public QuickFix.Fields.EntitlementReportID Get(QuickFix.Fields.EntitlementReportID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EntitlementReportID val)
            {
                return IsSetEntitlementReportID();
            }

            public bool IsSetEntitlementReportID()
            {
                return IsSetField(Tags.EntitlementReportID);
            }
            public QuickFix.Fields.EntitlementRequestID EntitlementRequestID
            {
                get
                {
                    QuickFix.Fields.EntitlementRequestID val = new QuickFix.Fields.EntitlementRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EntitlementRequestID val)
            {
                this.EntitlementRequestID = val;
            }

            public QuickFix.Fields.EntitlementRequestID Get(QuickFix.Fields.EntitlementRequestID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EntitlementRequestID val)
            {
                return IsSetEntitlementRequestID();
            }

            public bool IsSetEntitlementRequestID()
            {
                return IsSetField(Tags.EntitlementRequestID);
            }
            public QuickFix.Fields.RequestResult RequestResult
            {
                get
                {
                    QuickFix.Fields.RequestResult val = new QuickFix.Fields.RequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RequestResult val)
            {
                this.RequestResult = val;
            }

            public QuickFix.Fields.RequestResult Get(QuickFix.Fields.RequestResult val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RequestResult val)
            {
                return IsSetRequestResult();
            }

            public bool IsSetRequestResult()
            {
                return IsSetField(Tags.RequestResult);
            }
            public QuickFix.Fields.TotNoParties TotNoParties
            {
                get
                {
                    QuickFix.Fields.TotNoParties val = new QuickFix.Fields.TotNoParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNoParties val)
            {
                this.TotNoParties = val;
            }

            public QuickFix.Fields.TotNoParties Get(QuickFix.Fields.TotNoParties val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNoParties val)
            {
                return IsSetTotNoParties();
            }

            public bool IsSetTotNoParties()
            {
                return IsSetField(Tags.TotNoParties);
            }
            public QuickFix.Fields.LastFragment LastFragment
            {
                get
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.LastFragment val)
            {
                this.LastFragment = val;
            }

            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.LastFragment val)
            {
                return IsSetLastFragment();
            }

            public bool IsSetLastFragment()
            {
                return IsSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoPartyEntitlements NoPartyEntitlements
            {
                get
                {
                    QuickFix.Fields.NoPartyEntitlements val = new QuickFix.Fields.NoPartyEntitlements();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPartyEntitlements val)
            {
                this.NoPartyEntitlements = val;
            }

            public QuickFix.Fields.NoPartyEntitlements Get(QuickFix.Fields.NoPartyEntitlements val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPartyEntitlements val)
            {
                return IsSetNoPartyEntitlements();
            }

            public bool IsSetNoPartyEntitlements()
            {
                return IsSetField(Tags.NoPartyEntitlements);
            }
            public QuickFix.Fields.TransactTime TransactTime
            {
                get
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransactTime val)
            {
                this.TransactTime = val;
            }

            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransactTime val)
            {
                return IsSetTransactTime();
            }

            public bool IsSetTransactTime()
            {
                return IsSetField(Tags.TransactTime);
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
            public QuickFix.Fields.RejectText RejectText
            {
                get
                {
                    QuickFix.Fields.RejectText val = new QuickFix.Fields.RejectText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RejectText val)
            {
                this.RejectText = val;
            }

            public QuickFix.Fields.RejectText Get(QuickFix.Fields.RejectText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RejectText val)
            {
                return IsSetRejectText();
            }

            public bool IsSetRejectText()
            {
                return IsSetField(Tags.RejectText);
            }
            public QuickFix.Fields.EncodedRejectTextLen EncodedRejectTextLen
            {
                get
                {
                    QuickFix.Fields.EncodedRejectTextLen val = new QuickFix.Fields.EncodedRejectTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedRejectTextLen val)
            {
                this.EncodedRejectTextLen = val;
            }

            public QuickFix.Fields.EncodedRejectTextLen Get(QuickFix.Fields.EncodedRejectTextLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedRejectTextLen val)
            {
                return IsSetEncodedRejectTextLen();
            }

            public bool IsSetEncodedRejectTextLen()
            {
                return IsSetField(Tags.EncodedRejectTextLen);
            }
            public QuickFix.Fields.EncodedRejectText EncodedRejectText
            {
                get
                {
                    QuickFix.Fields.EncodedRejectText val = new QuickFix.Fields.EncodedRejectText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedRejectText val)
            {
                this.EncodedRejectText = val;
            }

            public QuickFix.Fields.EncodedRejectText Get(QuickFix.Fields.EncodedRejectText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedRejectText val)
            {
                return IsSetEncodedRejectText();
            }

            public bool IsSetEncodedRejectText()
            {
                return IsSetField(Tags.EncodedRejectText);
            }
            public class NoPartyEntitlementsGroup : Group
            {
                public static int[] fieldOrder = { Tags.NoPartyDetails, Tags.NoEntitlements, Tags.EntitlementStatus, 0 };

                public NoPartyEntitlementsGroup()
                  : base(Tags.NoPartyEntitlements, Tags.NoPartyDetails, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyEntitlementsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                public QuickFix.Fields.NoEntitlements NoEntitlements
                {
                    get
                    {
                        QuickFix.Fields.NoEntitlements val = new QuickFix.Fields.NoEntitlements();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoEntitlements val)
                {
                    this.NoEntitlements = val;
                }

                public QuickFix.Fields.NoEntitlements Get(QuickFix.Fields.NoEntitlements val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoEntitlements val)
                {
                    return IsSetNoEntitlements();
                }

                public bool IsSetNoEntitlements()
                {
                    return IsSetField(Tags.NoEntitlements);
                }
                public QuickFix.Fields.EntitlementStatus EntitlementStatus
                {
                    get
                    {
                        QuickFix.Fields.EntitlementStatus val = new QuickFix.Fields.EntitlementStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EntitlementStatus val)
                {
                    this.EntitlementStatus = val;
                }

                public QuickFix.Fields.EntitlementStatus Get(QuickFix.Fields.EntitlementStatus val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EntitlementStatus val)
                {
                    return IsSetEntitlementStatus();
                }

                public bool IsSetEntitlementStatus()
                {
                    return IsSetField(Tags.EntitlementStatus);
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
                public class NoEntitlementsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.EntitlementIndicator, Tags.EntitlementType, Tags.NoEntitlementAttrib, Tags.EntitlementID, Tags.EntitlementPlatform, Tags.NoInstrumentScopes, Tags.NoMarketSegments, Tags.EntitlementStartDate, Tags.EntitlementEndDate, Tags.EntitlementSubType, 0 };

                    public NoEntitlementsGroup()
                      : base(Tags.NoEntitlements, Tags.EntitlementIndicator, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoEntitlementsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.EntitlementIndicator EntitlementIndicator
                    {
                        get
                        {
                            QuickFix.Fields.EntitlementIndicator val = new QuickFix.Fields.EntitlementIndicator();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EntitlementIndicator val)
                    {
                        this.EntitlementIndicator = val;
                    }

                    public QuickFix.Fields.EntitlementIndicator Get(QuickFix.Fields.EntitlementIndicator val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EntitlementIndicator val)
                    {
                        return IsSetEntitlementIndicator();
                    }

                    public bool IsSetEntitlementIndicator()
                    {
                        return IsSetField(Tags.EntitlementIndicator);
                    }
                    public QuickFix.Fields.EntitlementType EntitlementType
                    {
                        get
                        {
                            QuickFix.Fields.EntitlementType val = new QuickFix.Fields.EntitlementType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EntitlementType val)
                    {
                        this.EntitlementType = val;
                    }

                    public QuickFix.Fields.EntitlementType Get(QuickFix.Fields.EntitlementType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EntitlementType val)
                    {
                        return IsSetEntitlementType();
                    }

                    public bool IsSetEntitlementType()
                    {
                        return IsSetField(Tags.EntitlementType);
                    }
                    public QuickFix.Fields.NoEntitlementAttrib NoEntitlementAttrib
                    {
                        get
                        {
                            QuickFix.Fields.NoEntitlementAttrib val = new QuickFix.Fields.NoEntitlementAttrib();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoEntitlementAttrib val)
                    {
                        this.NoEntitlementAttrib = val;
                    }

                    public QuickFix.Fields.NoEntitlementAttrib Get(QuickFix.Fields.NoEntitlementAttrib val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoEntitlementAttrib val)
                    {
                        return IsSetNoEntitlementAttrib();
                    }

                    public bool IsSetNoEntitlementAttrib()
                    {
                        return IsSetField(Tags.NoEntitlementAttrib);
                    }
                    public QuickFix.Fields.EntitlementID EntitlementID
                    {
                        get
                        {
                            QuickFix.Fields.EntitlementID val = new QuickFix.Fields.EntitlementID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EntitlementID val)
                    {
                        this.EntitlementID = val;
                    }

                    public QuickFix.Fields.EntitlementID Get(QuickFix.Fields.EntitlementID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EntitlementID val)
                    {
                        return IsSetEntitlementID();
                    }

                    public bool IsSetEntitlementID()
                    {
                        return IsSetField(Tags.EntitlementID);
                    }
                    public QuickFix.Fields.EntitlementPlatform EntitlementPlatform
                    {
                        get
                        {
                            QuickFix.Fields.EntitlementPlatform val = new QuickFix.Fields.EntitlementPlatform();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EntitlementPlatform val)
                    {
                        this.EntitlementPlatform = val;
                    }

                    public QuickFix.Fields.EntitlementPlatform Get(QuickFix.Fields.EntitlementPlatform val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EntitlementPlatform val)
                    {
                        return IsSetEntitlementPlatform();
                    }

                    public bool IsSetEntitlementPlatform()
                    {
                        return IsSetField(Tags.EntitlementPlatform);
                    }
                    public QuickFix.Fields.NoInstrumentScopes NoInstrumentScopes
                    {
                        get
                        {
                            QuickFix.Fields.NoInstrumentScopes val = new QuickFix.Fields.NoInstrumentScopes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoInstrumentScopes val)
                    {
                        this.NoInstrumentScopes = val;
                    }

                    public QuickFix.Fields.NoInstrumentScopes Get(QuickFix.Fields.NoInstrumentScopes val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoInstrumentScopes val)
                    {
                        return IsSetNoInstrumentScopes();
                    }

                    public bool IsSetNoInstrumentScopes()
                    {
                        return IsSetField(Tags.NoInstrumentScopes);
                    }
                    public QuickFix.Fields.NoMarketSegments NoMarketSegments
                    {
                        get
                        {
                            QuickFix.Fields.NoMarketSegments val = new QuickFix.Fields.NoMarketSegments();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoMarketSegments val)
                    {
                        this.NoMarketSegments = val;
                    }

                    public QuickFix.Fields.NoMarketSegments Get(QuickFix.Fields.NoMarketSegments val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoMarketSegments val)
                    {
                        return IsSetNoMarketSegments();
                    }

                    public bool IsSetNoMarketSegments()
                    {
                        return IsSetField(Tags.NoMarketSegments);
                    }
                    public QuickFix.Fields.EntitlementStartDate EntitlementStartDate
                    {
                        get
                        {
                            QuickFix.Fields.EntitlementStartDate val = new QuickFix.Fields.EntitlementStartDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EntitlementStartDate val)
                    {
                        this.EntitlementStartDate = val;
                    }

                    public QuickFix.Fields.EntitlementStartDate Get(QuickFix.Fields.EntitlementStartDate val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EntitlementStartDate val)
                    {
                        return IsSetEntitlementStartDate();
                    }

                    public bool IsSetEntitlementStartDate()
                    {
                        return IsSetField(Tags.EntitlementStartDate);
                    }
                    public QuickFix.Fields.EntitlementEndDate EntitlementEndDate
                    {
                        get
                        {
                            QuickFix.Fields.EntitlementEndDate val = new QuickFix.Fields.EntitlementEndDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EntitlementEndDate val)
                    {
                        this.EntitlementEndDate = val;
                    }

                    public QuickFix.Fields.EntitlementEndDate Get(QuickFix.Fields.EntitlementEndDate val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EntitlementEndDate val)
                    {
                        return IsSetEntitlementEndDate();
                    }

                    public bool IsSetEntitlementEndDate()
                    {
                        return IsSetField(Tags.EntitlementEndDate);
                    }
                    public QuickFix.Fields.EntitlementSubType EntitlementSubType
                    {
                        get
                        {
                            QuickFix.Fields.EntitlementSubType val = new QuickFix.Fields.EntitlementSubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EntitlementSubType val)
                    {
                        this.EntitlementSubType = val;
                    }

                    public QuickFix.Fields.EntitlementSubType Get(QuickFix.Fields.EntitlementSubType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EntitlementSubType val)
                    {
                        return IsSetEntitlementSubType();
                    }

                    public bool IsSetEntitlementSubType()
                    {
                        return IsSetField(Tags.EntitlementSubType);
                    }
                    public class NoEntitlementAttribGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.EntitlementAttribType, Tags.EntitlementAttribDatatype, Tags.EntitlementAttribValue, Tags.EntitlementAttribCurrency, 0 };

                        public NoEntitlementAttribGroup()
                          : base(Tags.NoEntitlementAttrib, Tags.EntitlementAttribType, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoEntitlementAttribGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.EntitlementAttribType EntitlementAttribType
                        {
                            get
                            {
                                QuickFix.Fields.EntitlementAttribType val = new QuickFix.Fields.EntitlementAttribType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.EntitlementAttribType val)
                        {
                            this.EntitlementAttribType = val;
                        }

                        public QuickFix.Fields.EntitlementAttribType Get(QuickFix.Fields.EntitlementAttribType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.EntitlementAttribType val)
                        {
                            return IsSetEntitlementAttribType();
                        }

                        public bool IsSetEntitlementAttribType()
                        {
                            return IsSetField(Tags.EntitlementAttribType);
                        }
                        public QuickFix.Fields.EntitlementAttribDatatype EntitlementAttribDatatype
                        {
                            get
                            {
                                QuickFix.Fields.EntitlementAttribDatatype val = new QuickFix.Fields.EntitlementAttribDatatype();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.EntitlementAttribDatatype val)
                        {
                            this.EntitlementAttribDatatype = val;
                        }

                        public QuickFix.Fields.EntitlementAttribDatatype Get(QuickFix.Fields.EntitlementAttribDatatype val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.EntitlementAttribDatatype val)
                        {
                            return IsSetEntitlementAttribDatatype();
                        }

                        public bool IsSetEntitlementAttribDatatype()
                        {
                            return IsSetField(Tags.EntitlementAttribDatatype);
                        }
                        public QuickFix.Fields.EntitlementAttribValue EntitlementAttribValue
                        {
                            get
                            {
                                QuickFix.Fields.EntitlementAttribValue val = new QuickFix.Fields.EntitlementAttribValue();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.EntitlementAttribValue val)
                        {
                            this.EntitlementAttribValue = val;
                        }

                        public QuickFix.Fields.EntitlementAttribValue Get(QuickFix.Fields.EntitlementAttribValue val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.EntitlementAttribValue val)
                        {
                            return IsSetEntitlementAttribValue();
                        }

                        public bool IsSetEntitlementAttribValue()
                        {
                            return IsSetField(Tags.EntitlementAttribValue);
                        }
                        public QuickFix.Fields.EntitlementAttribCurrency EntitlementAttribCurrency
                        {
                            get
                            {
                                QuickFix.Fields.EntitlementAttribCurrency val = new QuickFix.Fields.EntitlementAttribCurrency();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.EntitlementAttribCurrency val)
                        {
                            this.EntitlementAttribCurrency = val;
                        }

                        public QuickFix.Fields.EntitlementAttribCurrency Get(QuickFix.Fields.EntitlementAttribCurrency val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.EntitlementAttribCurrency val)
                        {
                            return IsSetEntitlementAttribCurrency();
                        }

                        public bool IsSetEntitlementAttribCurrency()
                        {
                            return IsSetField(Tags.EntitlementAttribCurrency);
                        }

                    }
                    public class NoInstrumentScopesGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.InstrumentScopeOperator, Tags.InstrumentScopeSymbol, Tags.InstrumentScopeSymbolSfx, Tags.InstrumentScopeSecurityID, Tags.InstrumentScopeSecurityIDSource, Tags.NoInstrumentScopeSecurityAltID, Tags.InstrumentScopeProduct, Tags.InstrumentScopeProductComplex, Tags.InstrumentScopeSecurityGroup, Tags.InstrumentScopeCFICode, Tags.InstrumentScopeSecurityType, Tags.InstrumentScopeSecuritySubType, Tags.InstrumentScopeMaturityMonthYear, Tags.InstrumentScopeMaturityTime, Tags.InstrumentScopeRestructuringType, Tags.InstrumentScopeSeniority, Tags.InstrumentScopePutOrCall, Tags.InstrumentScopeFlexibleIndicator, Tags.InstrumentScopeCouponRate, Tags.InstrumentScopeSecurityExchange, Tags.InstrumentScopeSecurityDesc, Tags.InstrumentScopeEncodedSecurityDescLen, Tags.InstrumentScopeEncodedSecurityDesc, Tags.InstrumentScopeSettlType, Tags.InstrumentScopeUPICode, 0 };

                        public NoInstrumentScopesGroup()
                          : base(Tags.NoInstrumentScopes, Tags.InstrumentScopeOperator, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoInstrumentScopesGroup();
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
                    public class NoMarketSegmentsGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.MarketID, Tags.MarketSegmentID, 0 };

                        public NoMarketSegmentsGroup()
                          : base(Tags.NoMarketSegments, Tags.MarketID, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoMarketSegmentsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.MarketID MarketID
                        {
                            get
                            {
                                QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.MarketID val)
                        {
                            this.MarketID = val;
                        }

                        public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.MarketID val)
                        {
                            return IsSetMarketID();
                        }

                        public bool IsSetMarketID()
                        {
                            return IsSetField(Tags.MarketID);
                        }
                        public QuickFix.Fields.MarketSegmentID MarketSegmentID
                        {
                            get
                            {
                                QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.MarketSegmentID val)
                        {
                            this.MarketSegmentID = val;
                        }

                        public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.MarketSegmentID val)
                        {
                            return IsSetMarketSegmentID();
                        }

                        public bool IsSetMarketSegmentID()
                        {
                            return IsSetField(Tags.MarketSegmentID);
                        }

                    }
                }
            }
        }
    }
}
