// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PositionTransferInstructionAck : Message
        {
            public const string MsgType = "DM";

            public PositionTransferInstructionAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("DM"));
            }

            public PositionTransferInstructionAck(
                    QuickFix.Fields.TransferInstructionID aTransferInstructionID
                ) : this()
            {
                this.TransferInstructionID = aTransferInstructionID;
            }

            public QuickFix.Fields.TransferInstructionID TransferInstructionID
            {
                get
                {
                    QuickFix.Fields.TransferInstructionID val = new QuickFix.Fields.TransferInstructionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransferInstructionID val)
            {
                this.TransferInstructionID = val;
            }

            public QuickFix.Fields.TransferInstructionID Get(QuickFix.Fields.TransferInstructionID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransferInstructionID val)
            {
                return IsSetTransferInstructionID();
            }

            public bool IsSetTransferInstructionID()
            {
                return IsSetField(Tags.TransferInstructionID);
            }
            public QuickFix.Fields.TransferID TransferID
            {
                get
                {
                    QuickFix.Fields.TransferID val = new QuickFix.Fields.TransferID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransferID val)
            {
                this.TransferID = val;
            }

            public QuickFix.Fields.TransferID Get(QuickFix.Fields.TransferID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransferID val)
            {
                return IsSetTransferID();
            }

            public bool IsSetTransferID()
            {
                return IsSetField(Tags.TransferID);
            }
            public QuickFix.Fields.TransferTransType TransferTransType
            {
                get
                {
                    QuickFix.Fields.TransferTransType val = new QuickFix.Fields.TransferTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransferTransType val)
            {
                this.TransferTransType = val;
            }

            public QuickFix.Fields.TransferTransType Get(QuickFix.Fields.TransferTransType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransferTransType val)
            {
                return IsSetTransferTransType();
            }

            public bool IsSetTransferTransType()
            {
                return IsSetField(Tags.TransferTransType);
            }
            public QuickFix.Fields.TransferType TransferType
            {
                get
                {
                    QuickFix.Fields.TransferType val = new QuickFix.Fields.TransferType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransferType val)
            {
                this.TransferType = val;
            }

            public QuickFix.Fields.TransferType Get(QuickFix.Fields.TransferType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransferType val)
            {
                return IsSetTransferType();
            }

            public bool IsSetTransferType()
            {
                return IsSetField(Tags.TransferType);
            }
            public QuickFix.Fields.TransferStatus TransferStatus
            {
                get
                {
                    QuickFix.Fields.TransferStatus val = new QuickFix.Fields.TransferStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransferStatus val)
            {
                this.TransferStatus = val;
            }

            public QuickFix.Fields.TransferStatus Get(QuickFix.Fields.TransferStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransferStatus val)
            {
                return IsSetTransferStatus();
            }

            public bool IsSetTransferStatus()
            {
                return IsSetField(Tags.TransferStatus);
            }
            public QuickFix.Fields.TransferRejectReason TransferRejectReason
            {
                get
                {
                    QuickFix.Fields.TransferRejectReason val = new QuickFix.Fields.TransferRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransferRejectReason val)
            {
                this.TransferRejectReason = val;
            }

            public QuickFix.Fields.TransferRejectReason Get(QuickFix.Fields.TransferRejectReason val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransferRejectReason val)
            {
                return IsSetTransferRejectReason();
            }

            public bool IsSetTransferRejectReason()
            {
                return IsSetField(Tags.TransferRejectReason);
            }
            public QuickFix.Fields.TransferScope TransferScope
            {
                get
                {
                    QuickFix.Fields.TransferScope val = new QuickFix.Fields.TransferScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransferScope val)
            {
                this.TransferScope = val;
            }

            public QuickFix.Fields.TransferScope Get(QuickFix.Fields.TransferScope val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransferScope val)
            {
                return IsSetTransferScope();
            }

            public bool IsSetTransferScope()
            {
                return IsSetField(Tags.TransferScope);
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
            public QuickFix.Fields.NoTargetPartyIDs NoTargetPartyIDs
            {
                get
                {
                    QuickFix.Fields.NoTargetPartyIDs val = new QuickFix.Fields.NoTargetPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoTargetPartyIDs val)
            {
                this.NoTargetPartyIDs = val;
            }

            public QuickFix.Fields.NoTargetPartyIDs Get(QuickFix.Fields.NoTargetPartyIDs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoTargetPartyIDs val)
            {
                return IsSetNoTargetPartyIDs();
            }

            public bool IsSetNoTargetPartyIDs()
            {
                return IsSetField(Tags.NoTargetPartyIDs);
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
            public class NoTargetPartyIDsGroup : Group
            {
                public static int[] fieldOrder = { Tags.TargetPartyID, Tags.TargetPartyIDSource, Tags.TargetPartyRole, Tags.TargetPartyRoleQualifier, Tags.NoTargetPartySubIDs, 0 };

                public NoTargetPartyIDsGroup()
                  : base(Tags.NoTargetPartyIDs, Tags.TargetPartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoTargetPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.TargetPartyID TargetPartyID
                {
                    get
                    {
                        QuickFix.Fields.TargetPartyID val = new QuickFix.Fields.TargetPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TargetPartyID val)
                {
                    this.TargetPartyID = val;
                }

                public QuickFix.Fields.TargetPartyID Get(QuickFix.Fields.TargetPartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TargetPartyID val)
                {
                    return IsSetTargetPartyID();
                }

                public bool IsSetTargetPartyID()
                {
                    return IsSetField(Tags.TargetPartyID);
                }
                public QuickFix.Fields.TargetPartyIDSource TargetPartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.TargetPartyIDSource val = new QuickFix.Fields.TargetPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TargetPartyIDSource val)
                {
                    this.TargetPartyIDSource = val;
                }

                public QuickFix.Fields.TargetPartyIDSource Get(QuickFix.Fields.TargetPartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TargetPartyIDSource val)
                {
                    return IsSetTargetPartyIDSource();
                }

                public bool IsSetTargetPartyIDSource()
                {
                    return IsSetField(Tags.TargetPartyIDSource);
                }
                public QuickFix.Fields.TargetPartyRole TargetPartyRole
                {
                    get
                    {
                        QuickFix.Fields.TargetPartyRole val = new QuickFix.Fields.TargetPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TargetPartyRole val)
                {
                    this.TargetPartyRole = val;
                }

                public QuickFix.Fields.TargetPartyRole Get(QuickFix.Fields.TargetPartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TargetPartyRole val)
                {
                    return IsSetTargetPartyRole();
                }

                public bool IsSetTargetPartyRole()
                {
                    return IsSetField(Tags.TargetPartyRole);
                }
                public QuickFix.Fields.TargetPartyRoleQualifier TargetPartyRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.TargetPartyRoleQualifier val = new QuickFix.Fields.TargetPartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TargetPartyRoleQualifier val)
                {
                    this.TargetPartyRoleQualifier = val;
                }

                public QuickFix.Fields.TargetPartyRoleQualifier Get(QuickFix.Fields.TargetPartyRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TargetPartyRoleQualifier val)
                {
                    return IsSetTargetPartyRoleQualifier();
                }

                public bool IsSetTargetPartyRoleQualifier()
                {
                    return IsSetField(Tags.TargetPartyRoleQualifier);
                }
                public QuickFix.Fields.NoTargetPartySubIDs NoTargetPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoTargetPartySubIDs val = new QuickFix.Fields.NoTargetPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoTargetPartySubIDs val)
                {
                    this.NoTargetPartySubIDs = val;
                }

                public QuickFix.Fields.NoTargetPartySubIDs Get(QuickFix.Fields.NoTargetPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoTargetPartySubIDs val)
                {
                    return IsSetNoTargetPartySubIDs();
                }

                public bool IsSetNoTargetPartySubIDs()
                {
                    return IsSetField(Tags.NoTargetPartySubIDs);
                }
                public class NoTargetPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.TargetPartySubID, Tags.TargetPartySubIDType, 0 };

                    public NoTargetPartySubIDsGroup()
                      : base(Tags.NoTargetPartySubIDs, Tags.TargetPartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoTargetPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.TargetPartySubID TargetPartySubID
                    {
                        get
                        {
                            QuickFix.Fields.TargetPartySubID val = new QuickFix.Fields.TargetPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.TargetPartySubID val)
                    {
                        this.TargetPartySubID = val;
                    }

                    public QuickFix.Fields.TargetPartySubID Get(QuickFix.Fields.TargetPartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.TargetPartySubID val)
                    {
                        return IsSetTargetPartySubID();
                    }

                    public bool IsSetTargetPartySubID()
                    {
                        return IsSetField(Tags.TargetPartySubID);
                    }
                    public QuickFix.Fields.TargetPartySubIDType TargetPartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.TargetPartySubIDType val = new QuickFix.Fields.TargetPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.TargetPartySubIDType val)
                    {
                        this.TargetPartySubIDType = val;
                    }

                    public QuickFix.Fields.TargetPartySubIDType Get(QuickFix.Fields.TargetPartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.TargetPartySubIDType val)
                    {
                        return IsSetTargetPartySubIDType();
                    }

                    public bool IsSetTargetPartySubIDType()
                    {
                        return IsSetField(Tags.TargetPartySubIDType);
                    }

                }
            }
        }
    }
}
