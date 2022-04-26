// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PartyDetailsListReport : Message
        {
            public const string MsgType = "CG";

            public PartyDetailsListReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CG"));
            }

            public PartyDetailsListReport(
                    QuickFix.Fields.PartyDetailsListReportID aPartyDetailsListReportID
                ) : this()
            {
                this.PartyDetailsListReportID = aPartyDetailsListReportID;
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
            public QuickFix.Fields.PartyDetailsListReportID PartyDetailsListReportID
            {
                get
                {
                    QuickFix.Fields.PartyDetailsListReportID val = new QuickFix.Fields.PartyDetailsListReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PartyDetailsListReportID val)
            {
                this.PartyDetailsListReportID = val;
            }

            public QuickFix.Fields.PartyDetailsListReportID Get(QuickFix.Fields.PartyDetailsListReportID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PartyDetailsListReportID val)
            {
                return IsSetPartyDetailsListReportID();
            }

            public bool IsSetPartyDetailsListReportID()
            {
                return IsSetField(Tags.PartyDetailsListReportID);
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
        }
    }
}
