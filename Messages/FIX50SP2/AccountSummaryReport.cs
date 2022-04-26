// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class AccountSummaryReport : Message
        {
            public const string MsgType = "CQ";

            public AccountSummaryReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CQ"));
            }

            public AccountSummaryReport(
                    QuickFix.Fields.AccountSummaryReportID aAccountSummaryReportID,
                    QuickFix.Fields.ClearingBusinessDate aClearingBusinessDate
                ) : this()
            {
                this.AccountSummaryReportID = aAccountSummaryReportID;
                this.ClearingBusinessDate = aClearingBusinessDate;
            }

            public QuickFix.Fields.AccountSummaryReportID AccountSummaryReportID
            {
                get
                {
                    QuickFix.Fields.AccountSummaryReportID val = new QuickFix.Fields.AccountSummaryReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AccountSummaryReportID val)
            {
                this.AccountSummaryReportID = val;
            }

            public QuickFix.Fields.AccountSummaryReportID Get(QuickFix.Fields.AccountSummaryReportID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AccountSummaryReportID val)
            {
                return IsSetAccountSummaryReportID();
            }

            public bool IsSetAccountSummaryReportID()
            {
                return IsSetField(Tags.AccountSummaryReportID);
            }
            public QuickFix.Fields.ClearingBusinessDate ClearingBusinessDate
            {
                get
                {
                    QuickFix.Fields.ClearingBusinessDate val = new QuickFix.Fields.ClearingBusinessDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClearingBusinessDate val)
            {
                this.ClearingBusinessDate = val;
            }

            public QuickFix.Fields.ClearingBusinessDate Get(QuickFix.Fields.ClearingBusinessDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClearingBusinessDate val)
            {
                return IsSetClearingBusinessDate();
            }

            public bool IsSetClearingBusinessDate()
            {
                return IsSetField(Tags.ClearingBusinessDate);
            }
            public QuickFix.Fields.TotalNetValue TotalNetValue
            {
                get
                {
                    QuickFix.Fields.TotalNetValue val = new QuickFix.Fields.TotalNetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotalNetValue val)
            {
                this.TotalNetValue = val;
            }

            public QuickFix.Fields.TotalNetValue Get(QuickFix.Fields.TotalNetValue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotalNetValue val)
            {
                return IsSetTotalNetValue();
            }

            public bool IsSetTotalNetValue()
            {
                return IsSetField(Tags.TotalNetValue);
            }
            public QuickFix.Fields.MarginExcess MarginExcess
            {
                get
                {
                    QuickFix.Fields.MarginExcess val = new QuickFix.Fields.MarginExcess();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarginExcess val)
            {
                this.MarginExcess = val;
            }

            public QuickFix.Fields.MarginExcess Get(QuickFix.Fields.MarginExcess val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarginExcess val)
            {
                return IsSetMarginExcess();
            }

            public bool IsSetMarginExcess()
            {
                return IsSetField(Tags.MarginExcess);
            }
            public QuickFix.Fields.NoSettlementAmounts NoSettlementAmounts
            {
                get
                {
                    QuickFix.Fields.NoSettlementAmounts val = new QuickFix.Fields.NoSettlementAmounts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoSettlementAmounts val)
            {
                this.NoSettlementAmounts = val;
            }

            public QuickFix.Fields.NoSettlementAmounts Get(QuickFix.Fields.NoSettlementAmounts val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoSettlementAmounts val)
            {
                return IsSetNoSettlementAmounts();
            }

            public bool IsSetNoSettlementAmounts()
            {
                return IsSetField(Tags.NoSettlementAmounts);
            }
            public QuickFix.Fields.NoMarginAmt NoMarginAmt
            {
                get
                {
                    QuickFix.Fields.NoMarginAmt val = new QuickFix.Fields.NoMarginAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMarginAmt val)
            {
                this.NoMarginAmt = val;
            }

            public QuickFix.Fields.NoMarginAmt Get(QuickFix.Fields.NoMarginAmt val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMarginAmt val)
            {
                return IsSetNoMarginAmt();
            }

            public bool IsSetNoMarginAmt()
            {
                return IsSetField(Tags.NoMarginAmt);
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
            public QuickFix.Fields.NoCollateralAmounts NoCollateralAmounts
            {
                get
                {
                    QuickFix.Fields.NoCollateralAmounts val = new QuickFix.Fields.NoCollateralAmounts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoCollateralAmounts val)
            {
                this.NoCollateralAmounts = val;
            }

            public QuickFix.Fields.NoCollateralAmounts Get(QuickFix.Fields.NoCollateralAmounts val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoCollateralAmounts val)
            {
                return IsSetNoCollateralAmounts();
            }

            public bool IsSetNoCollateralAmounts()
            {
                return IsSetField(Tags.NoCollateralAmounts);
            }
            public QuickFix.Fields.NoPayCollects NoPayCollects
            {
                get
                {
                    QuickFix.Fields.NoPayCollects val = new QuickFix.Fields.NoPayCollects();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPayCollects val)
            {
                this.NoPayCollects = val;
            }

            public QuickFix.Fields.NoPayCollects Get(QuickFix.Fields.NoPayCollects val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPayCollects val)
            {
                return IsSetNoPayCollects();
            }

            public bool IsSetNoPayCollects()
            {
                return IsSetField(Tags.NoPayCollects);
            }
            public QuickFix.Fields.SettlSessID SettlSessID
            {
                get
                {
                    QuickFix.Fields.SettlSessID val = new QuickFix.Fields.SettlSessID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SettlSessID val)
            {
                this.SettlSessID = val;
            }

            public QuickFix.Fields.SettlSessID Get(QuickFix.Fields.SettlSessID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SettlSessID val)
            {
                return IsSetSettlSessID();
            }

            public bool IsSetSettlSessID()
            {
                return IsSetField(Tags.SettlSessID);
            }
            public QuickFix.Fields.SettlSessSubID SettlSessSubID
            {
                get
                {
                    QuickFix.Fields.SettlSessSubID val = new QuickFix.Fields.SettlSessSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SettlSessSubID val)
            {
                this.SettlSessSubID = val;
            }

            public QuickFix.Fields.SettlSessSubID Get(QuickFix.Fields.SettlSessSubID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SettlSessSubID val)
            {
                return IsSetSettlSessSubID();
            }

            public bool IsSetSettlSessSubID()
            {
                return IsSetField(Tags.SettlSessSubID);
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
            public QuickFix.Fields.Currency Currency
            {
                get
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Currency val)
            {
                this.Currency = val;
            }

            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Currency val)
            {
                return IsSetCurrency();
            }

            public bool IsSetCurrency()
            {
                return IsSetField(Tags.Currency);
            }
            public QuickFix.Fields.NoPosAmt NoPosAmt
            {
                get
                {
                    QuickFix.Fields.NoPosAmt val = new QuickFix.Fields.NoPosAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPosAmt val)
            {
                this.NoPosAmt = val;
            }

            public QuickFix.Fields.NoPosAmt Get(QuickFix.Fields.NoPosAmt val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPosAmt val)
            {
                return IsSetNoPosAmt();
            }

            public bool IsSetNoPosAmt()
            {
                return IsSetField(Tags.NoPosAmt);
            }
            public class NoSettlementAmountsGroup : Group
            {
                public static int[] fieldOrder = { Tags.SettlementAmount, Tags.SettlementAmountCurrency, 0 };

                public NoSettlementAmountsGroup()
                  : base(Tags.NoSettlementAmounts, Tags.SettlementAmount, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoSettlementAmountsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.SettlementAmount SettlementAmount
                {
                    get
                    {
                        QuickFix.Fields.SettlementAmount val = new QuickFix.Fields.SettlementAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlementAmount val)
                {
                    this.SettlementAmount = val;
                }

                public QuickFix.Fields.SettlementAmount Get(QuickFix.Fields.SettlementAmount val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlementAmount val)
                {
                    return IsSetSettlementAmount();
                }

                public bool IsSetSettlementAmount()
                {
                    return IsSetField(Tags.SettlementAmount);
                }
                public QuickFix.Fields.SettlementAmountCurrency SettlementAmountCurrency
                {
                    get
                    {
                        QuickFix.Fields.SettlementAmountCurrency val = new QuickFix.Fields.SettlementAmountCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlementAmountCurrency val)
                {
                    this.SettlementAmountCurrency = val;
                }

                public QuickFix.Fields.SettlementAmountCurrency Get(QuickFix.Fields.SettlementAmountCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlementAmountCurrency val)
                {
                    return IsSetSettlementAmountCurrency();
                }

                public bool IsSetSettlementAmountCurrency()
                {
                    return IsSetField(Tags.SettlementAmountCurrency);
                }

            }
            public class NoMarginAmtGroup : Group
            {
                public static int[] fieldOrder = { Tags.MarginAmt, Tags.MarginAmtType, Tags.MarginAmtCcy, Tags.MarginAmountMarketSegmentID, Tags.MarginAmountMarketID, Tags.MarginAmtFXRate, Tags.MarginAmtFXRateCalc, Tags.MarginDirection, 0 };

                public NoMarginAmtGroup()
                  : base(Tags.NoMarginAmt, Tags.MarginAmt, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMarginAmtGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MarginAmt MarginAmt
                {
                    get
                    {
                        QuickFix.Fields.MarginAmt val = new QuickFix.Fields.MarginAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginAmt val)
                {
                    this.MarginAmt = val;
                }

                public QuickFix.Fields.MarginAmt Get(QuickFix.Fields.MarginAmt val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginAmt val)
                {
                    return IsSetMarginAmt();
                }

                public bool IsSetMarginAmt()
                {
                    return IsSetField(Tags.MarginAmt);
                }
                public QuickFix.Fields.MarginAmtType MarginAmtType
                {
                    get
                    {
                        QuickFix.Fields.MarginAmtType val = new QuickFix.Fields.MarginAmtType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginAmtType val)
                {
                    this.MarginAmtType = val;
                }

                public QuickFix.Fields.MarginAmtType Get(QuickFix.Fields.MarginAmtType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginAmtType val)
                {
                    return IsSetMarginAmtType();
                }

                public bool IsSetMarginAmtType()
                {
                    return IsSetField(Tags.MarginAmtType);
                }
                public QuickFix.Fields.MarginAmtCcy MarginAmtCcy
                {
                    get
                    {
                        QuickFix.Fields.MarginAmtCcy val = new QuickFix.Fields.MarginAmtCcy();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginAmtCcy val)
                {
                    this.MarginAmtCcy = val;
                }

                public QuickFix.Fields.MarginAmtCcy Get(QuickFix.Fields.MarginAmtCcy val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginAmtCcy val)
                {
                    return IsSetMarginAmtCcy();
                }

                public bool IsSetMarginAmtCcy()
                {
                    return IsSetField(Tags.MarginAmtCcy);
                }
                public QuickFix.Fields.MarginAmountMarketSegmentID MarginAmountMarketSegmentID
                {
                    get
                    {
                        QuickFix.Fields.MarginAmountMarketSegmentID val = new QuickFix.Fields.MarginAmountMarketSegmentID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginAmountMarketSegmentID val)
                {
                    this.MarginAmountMarketSegmentID = val;
                }

                public QuickFix.Fields.MarginAmountMarketSegmentID Get(QuickFix.Fields.MarginAmountMarketSegmentID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginAmountMarketSegmentID val)
                {
                    return IsSetMarginAmountMarketSegmentID();
                }

                public bool IsSetMarginAmountMarketSegmentID()
                {
                    return IsSetField(Tags.MarginAmountMarketSegmentID);
                }
                public QuickFix.Fields.MarginAmountMarketID MarginAmountMarketID
                {
                    get
                    {
                        QuickFix.Fields.MarginAmountMarketID val = new QuickFix.Fields.MarginAmountMarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginAmountMarketID val)
                {
                    this.MarginAmountMarketID = val;
                }

                public QuickFix.Fields.MarginAmountMarketID Get(QuickFix.Fields.MarginAmountMarketID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginAmountMarketID val)
                {
                    return IsSetMarginAmountMarketID();
                }

                public bool IsSetMarginAmountMarketID()
                {
                    return IsSetField(Tags.MarginAmountMarketID);
                }
                public QuickFix.Fields.MarginAmtFXRate MarginAmtFXRate
                {
                    get
                    {
                        QuickFix.Fields.MarginAmtFXRate val = new QuickFix.Fields.MarginAmtFXRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginAmtFXRate val)
                {
                    this.MarginAmtFXRate = val;
                }

                public QuickFix.Fields.MarginAmtFXRate Get(QuickFix.Fields.MarginAmtFXRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginAmtFXRate val)
                {
                    return IsSetMarginAmtFXRate();
                }

                public bool IsSetMarginAmtFXRate()
                {
                    return IsSetField(Tags.MarginAmtFXRate);
                }
                public QuickFix.Fields.MarginAmtFXRateCalc MarginAmtFXRateCalc
                {
                    get
                    {
                        QuickFix.Fields.MarginAmtFXRateCalc val = new QuickFix.Fields.MarginAmtFXRateCalc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginAmtFXRateCalc val)
                {
                    this.MarginAmtFXRateCalc = val;
                }

                public QuickFix.Fields.MarginAmtFXRateCalc Get(QuickFix.Fields.MarginAmtFXRateCalc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginAmtFXRateCalc val)
                {
                    return IsSetMarginAmtFXRateCalc();
                }

                public bool IsSetMarginAmtFXRateCalc()
                {
                    return IsSetField(Tags.MarginAmtFXRateCalc);
                }
                public QuickFix.Fields.MarginDirection MarginDirection
                {
                    get
                    {
                        QuickFix.Fields.MarginDirection val = new QuickFix.Fields.MarginDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarginDirection val)
                {
                    this.MarginDirection = val;
                }

                public QuickFix.Fields.MarginDirection Get(QuickFix.Fields.MarginDirection val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarginDirection val)
                {
                    return IsSetMarginDirection();
                }

                public bool IsSetMarginDirection()
                {
                    return IsSetField(Tags.MarginDirection);
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
            public class NoCollateralAmountsGroup : Group
            {
                public static int[] fieldOrder = { Tags.CurrentCollateralAmount, Tags.CollateralCurrency, Tags.CollateralType, Tags.HaircutIndicator, Tags.CollateralFXRate, Tags.CollateralFXRateCalc, Tags.CollateralAmountMarketSegmentID, Tags.CollateralAmountMarketID, Tags.CollateralPortfolioID, Tags.CollateralAmountType, Tags.CollateralPercentOverage, Tags.CollateralMarketPrice, Tags.CollateralReinvestmentRate, Tags.NoCollateralReinvestments, Tags.UnderlyingRefID, 0 };

                public NoCollateralAmountsGroup()
                  : base(Tags.NoCollateralAmounts, Tags.CurrentCollateralAmount, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoCollateralAmountsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.CurrentCollateralAmount CurrentCollateralAmount
                {
                    get
                    {
                        QuickFix.Fields.CurrentCollateralAmount val = new QuickFix.Fields.CurrentCollateralAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CurrentCollateralAmount val)
                {
                    this.CurrentCollateralAmount = val;
                }

                public QuickFix.Fields.CurrentCollateralAmount Get(QuickFix.Fields.CurrentCollateralAmount val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CurrentCollateralAmount val)
                {
                    return IsSetCurrentCollateralAmount();
                }

                public bool IsSetCurrentCollateralAmount()
                {
                    return IsSetField(Tags.CurrentCollateralAmount);
                }
                public QuickFix.Fields.CollateralCurrency CollateralCurrency
                {
                    get
                    {
                        QuickFix.Fields.CollateralCurrency val = new QuickFix.Fields.CollateralCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralCurrency val)
                {
                    this.CollateralCurrency = val;
                }

                public QuickFix.Fields.CollateralCurrency Get(QuickFix.Fields.CollateralCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralCurrency val)
                {
                    return IsSetCollateralCurrency();
                }

                public bool IsSetCollateralCurrency()
                {
                    return IsSetField(Tags.CollateralCurrency);
                }
                public QuickFix.Fields.CollateralType CollateralType
                {
                    get
                    {
                        QuickFix.Fields.CollateralType val = new QuickFix.Fields.CollateralType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralType val)
                {
                    this.CollateralType = val;
                }

                public QuickFix.Fields.CollateralType Get(QuickFix.Fields.CollateralType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralType val)
                {
                    return IsSetCollateralType();
                }

                public bool IsSetCollateralType()
                {
                    return IsSetField(Tags.CollateralType);
                }
                public QuickFix.Fields.HaircutIndicator HaircutIndicator
                {
                    get
                    {
                        QuickFix.Fields.HaircutIndicator val = new QuickFix.Fields.HaircutIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.HaircutIndicator val)
                {
                    this.HaircutIndicator = val;
                }

                public QuickFix.Fields.HaircutIndicator Get(QuickFix.Fields.HaircutIndicator val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.HaircutIndicator val)
                {
                    return IsSetHaircutIndicator();
                }

                public bool IsSetHaircutIndicator()
                {
                    return IsSetField(Tags.HaircutIndicator);
                }
                public QuickFix.Fields.CollateralFXRate CollateralFXRate
                {
                    get
                    {
                        QuickFix.Fields.CollateralFXRate val = new QuickFix.Fields.CollateralFXRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralFXRate val)
                {
                    this.CollateralFXRate = val;
                }

                public QuickFix.Fields.CollateralFXRate Get(QuickFix.Fields.CollateralFXRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralFXRate val)
                {
                    return IsSetCollateralFXRate();
                }

                public bool IsSetCollateralFXRate()
                {
                    return IsSetField(Tags.CollateralFXRate);
                }
                public QuickFix.Fields.CollateralFXRateCalc CollateralFXRateCalc
                {
                    get
                    {
                        QuickFix.Fields.CollateralFXRateCalc val = new QuickFix.Fields.CollateralFXRateCalc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralFXRateCalc val)
                {
                    this.CollateralFXRateCalc = val;
                }

                public QuickFix.Fields.CollateralFXRateCalc Get(QuickFix.Fields.CollateralFXRateCalc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralFXRateCalc val)
                {
                    return IsSetCollateralFXRateCalc();
                }

                public bool IsSetCollateralFXRateCalc()
                {
                    return IsSetField(Tags.CollateralFXRateCalc);
                }
                public QuickFix.Fields.CollateralAmountMarketSegmentID CollateralAmountMarketSegmentID
                {
                    get
                    {
                        QuickFix.Fields.CollateralAmountMarketSegmentID val = new QuickFix.Fields.CollateralAmountMarketSegmentID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralAmountMarketSegmentID val)
                {
                    this.CollateralAmountMarketSegmentID = val;
                }

                public QuickFix.Fields.CollateralAmountMarketSegmentID Get(QuickFix.Fields.CollateralAmountMarketSegmentID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralAmountMarketSegmentID val)
                {
                    return IsSetCollateralAmountMarketSegmentID();
                }

                public bool IsSetCollateralAmountMarketSegmentID()
                {
                    return IsSetField(Tags.CollateralAmountMarketSegmentID);
                }
                public QuickFix.Fields.CollateralAmountMarketID CollateralAmountMarketID
                {
                    get
                    {
                        QuickFix.Fields.CollateralAmountMarketID val = new QuickFix.Fields.CollateralAmountMarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralAmountMarketID val)
                {
                    this.CollateralAmountMarketID = val;
                }

                public QuickFix.Fields.CollateralAmountMarketID Get(QuickFix.Fields.CollateralAmountMarketID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralAmountMarketID val)
                {
                    return IsSetCollateralAmountMarketID();
                }

                public bool IsSetCollateralAmountMarketID()
                {
                    return IsSetField(Tags.CollateralAmountMarketID);
                }
                public QuickFix.Fields.CollateralPortfolioID CollateralPortfolioID
                {
                    get
                    {
                        QuickFix.Fields.CollateralPortfolioID val = new QuickFix.Fields.CollateralPortfolioID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralPortfolioID val)
                {
                    this.CollateralPortfolioID = val;
                }

                public QuickFix.Fields.CollateralPortfolioID Get(QuickFix.Fields.CollateralPortfolioID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralPortfolioID val)
                {
                    return IsSetCollateralPortfolioID();
                }

                public bool IsSetCollateralPortfolioID()
                {
                    return IsSetField(Tags.CollateralPortfolioID);
                }
                public QuickFix.Fields.CollateralAmountType CollateralAmountType
                {
                    get
                    {
                        QuickFix.Fields.CollateralAmountType val = new QuickFix.Fields.CollateralAmountType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralAmountType val)
                {
                    this.CollateralAmountType = val;
                }

                public QuickFix.Fields.CollateralAmountType Get(QuickFix.Fields.CollateralAmountType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralAmountType val)
                {
                    return IsSetCollateralAmountType();
                }

                public bool IsSetCollateralAmountType()
                {
                    return IsSetField(Tags.CollateralAmountType);
                }
                public QuickFix.Fields.CollateralPercentOverage CollateralPercentOverage
                {
                    get
                    {
                        QuickFix.Fields.CollateralPercentOverage val = new QuickFix.Fields.CollateralPercentOverage();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralPercentOverage val)
                {
                    this.CollateralPercentOverage = val;
                }

                public QuickFix.Fields.CollateralPercentOverage Get(QuickFix.Fields.CollateralPercentOverage val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralPercentOverage val)
                {
                    return IsSetCollateralPercentOverage();
                }

                public bool IsSetCollateralPercentOverage()
                {
                    return IsSetField(Tags.CollateralPercentOverage);
                }
                public QuickFix.Fields.CollateralMarketPrice CollateralMarketPrice
                {
                    get
                    {
                        QuickFix.Fields.CollateralMarketPrice val = new QuickFix.Fields.CollateralMarketPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralMarketPrice val)
                {
                    this.CollateralMarketPrice = val;
                }

                public QuickFix.Fields.CollateralMarketPrice Get(QuickFix.Fields.CollateralMarketPrice val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralMarketPrice val)
                {
                    return IsSetCollateralMarketPrice();
                }

                public bool IsSetCollateralMarketPrice()
                {
                    return IsSetField(Tags.CollateralMarketPrice);
                }
                public QuickFix.Fields.CollateralReinvestmentRate CollateralReinvestmentRate
                {
                    get
                    {
                        QuickFix.Fields.CollateralReinvestmentRate val = new QuickFix.Fields.CollateralReinvestmentRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollateralReinvestmentRate val)
                {
                    this.CollateralReinvestmentRate = val;
                }

                public QuickFix.Fields.CollateralReinvestmentRate Get(QuickFix.Fields.CollateralReinvestmentRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollateralReinvestmentRate val)
                {
                    return IsSetCollateralReinvestmentRate();
                }

                public bool IsSetCollateralReinvestmentRate()
                {
                    return IsSetField(Tags.CollateralReinvestmentRate);
                }
                public QuickFix.Fields.NoCollateralReinvestments NoCollateralReinvestments
                {
                    get
                    {
                        QuickFix.Fields.NoCollateralReinvestments val = new QuickFix.Fields.NoCollateralReinvestments();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoCollateralReinvestments val)
                {
                    this.NoCollateralReinvestments = val;
                }

                public QuickFix.Fields.NoCollateralReinvestments Get(QuickFix.Fields.NoCollateralReinvestments val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoCollateralReinvestments val)
                {
                    return IsSetNoCollateralReinvestments();
                }

                public bool IsSetNoCollateralReinvestments()
                {
                    return IsSetField(Tags.NoCollateralReinvestments);
                }
                public QuickFix.Fields.UnderlyingRefID UnderlyingRefID
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingRefID val = new QuickFix.Fields.UnderlyingRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingRefID val)
                {
                    this.UnderlyingRefID = val;
                }

                public QuickFix.Fields.UnderlyingRefID Get(QuickFix.Fields.UnderlyingRefID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingRefID val)
                {
                    return IsSetUnderlyingRefID();
                }

                public bool IsSetUnderlyingRefID()
                {
                    return IsSetField(Tags.UnderlyingRefID);
                }
                public class NoCollateralReinvestmentsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.CollateralReinvestmentType, Tags.CollateralReinvestmentAmount, Tags.CollateralReinvestmentCurrency, 0 };

                    public NoCollateralReinvestmentsGroup()
                      : base(Tags.NoCollateralReinvestments, Tags.CollateralReinvestmentType, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoCollateralReinvestmentsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.CollateralReinvestmentType CollateralReinvestmentType
                    {
                        get
                        {
                            QuickFix.Fields.CollateralReinvestmentType val = new QuickFix.Fields.CollateralReinvestmentType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.CollateralReinvestmentType val)
                    {
                        this.CollateralReinvestmentType = val;
                    }

                    public QuickFix.Fields.CollateralReinvestmentType Get(QuickFix.Fields.CollateralReinvestmentType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.CollateralReinvestmentType val)
                    {
                        return IsSetCollateralReinvestmentType();
                    }

                    public bool IsSetCollateralReinvestmentType()
                    {
                        return IsSetField(Tags.CollateralReinvestmentType);
                    }
                    public QuickFix.Fields.CollateralReinvestmentAmount CollateralReinvestmentAmount
                    {
                        get
                        {
                            QuickFix.Fields.CollateralReinvestmentAmount val = new QuickFix.Fields.CollateralReinvestmentAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.CollateralReinvestmentAmount val)
                    {
                        this.CollateralReinvestmentAmount = val;
                    }

                    public QuickFix.Fields.CollateralReinvestmentAmount Get(QuickFix.Fields.CollateralReinvestmentAmount val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.CollateralReinvestmentAmount val)
                    {
                        return IsSetCollateralReinvestmentAmount();
                    }

                    public bool IsSetCollateralReinvestmentAmount()
                    {
                        return IsSetField(Tags.CollateralReinvestmentAmount);
                    }
                    public QuickFix.Fields.CollateralReinvestmentCurrency CollateralReinvestmentCurrency
                    {
                        get
                        {
                            QuickFix.Fields.CollateralReinvestmentCurrency val = new QuickFix.Fields.CollateralReinvestmentCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.CollateralReinvestmentCurrency val)
                    {
                        this.CollateralReinvestmentCurrency = val;
                    }

                    public QuickFix.Fields.CollateralReinvestmentCurrency Get(QuickFix.Fields.CollateralReinvestmentCurrency val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.CollateralReinvestmentCurrency val)
                    {
                        return IsSetCollateralReinvestmentCurrency();
                    }

                    public bool IsSetCollateralReinvestmentCurrency()
                    {
                        return IsSetField(Tags.CollateralReinvestmentCurrency);
                    }

                }
            }
            public class NoPayCollectsGroup : Group
            {
                public static int[] fieldOrder = { Tags.PayCollectType, Tags.PayCollectCurrency, Tags.PayAmount, Tags.CollectAmount, Tags.PayCollectMarketSegmentID, Tags.PayCollectMarketID, Tags.PayCollectFXRate, Tags.PayCollectFXRateCalc, 0 };

                public NoPayCollectsGroup()
                  : base(Tags.NoPayCollects, Tags.PayCollectType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPayCollectsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.PayCollectType PayCollectType
                {
                    get
                    {
                        QuickFix.Fields.PayCollectType val = new QuickFix.Fields.PayCollectType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PayCollectType val)
                {
                    this.PayCollectType = val;
                }

                public QuickFix.Fields.PayCollectType Get(QuickFix.Fields.PayCollectType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PayCollectType val)
                {
                    return IsSetPayCollectType();
                }

                public bool IsSetPayCollectType()
                {
                    return IsSetField(Tags.PayCollectType);
                }
                public QuickFix.Fields.PayCollectCurrency PayCollectCurrency
                {
                    get
                    {
                        QuickFix.Fields.PayCollectCurrency val = new QuickFix.Fields.PayCollectCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PayCollectCurrency val)
                {
                    this.PayCollectCurrency = val;
                }

                public QuickFix.Fields.PayCollectCurrency Get(QuickFix.Fields.PayCollectCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PayCollectCurrency val)
                {
                    return IsSetPayCollectCurrency();
                }

                public bool IsSetPayCollectCurrency()
                {
                    return IsSetField(Tags.PayCollectCurrency);
                }
                public QuickFix.Fields.PayAmount PayAmount
                {
                    get
                    {
                        QuickFix.Fields.PayAmount val = new QuickFix.Fields.PayAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PayAmount val)
                {
                    this.PayAmount = val;
                }

                public QuickFix.Fields.PayAmount Get(QuickFix.Fields.PayAmount val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PayAmount val)
                {
                    return IsSetPayAmount();
                }

                public bool IsSetPayAmount()
                {
                    return IsSetField(Tags.PayAmount);
                }
                public QuickFix.Fields.CollectAmount CollectAmount
                {
                    get
                    {
                        QuickFix.Fields.CollectAmount val = new QuickFix.Fields.CollectAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollectAmount val)
                {
                    this.CollectAmount = val;
                }

                public QuickFix.Fields.CollectAmount Get(QuickFix.Fields.CollectAmount val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollectAmount val)
                {
                    return IsSetCollectAmount();
                }

                public bool IsSetCollectAmount()
                {
                    return IsSetField(Tags.CollectAmount);
                }
                public QuickFix.Fields.PayCollectMarketSegmentID PayCollectMarketSegmentID
                {
                    get
                    {
                        QuickFix.Fields.PayCollectMarketSegmentID val = new QuickFix.Fields.PayCollectMarketSegmentID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PayCollectMarketSegmentID val)
                {
                    this.PayCollectMarketSegmentID = val;
                }

                public QuickFix.Fields.PayCollectMarketSegmentID Get(QuickFix.Fields.PayCollectMarketSegmentID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PayCollectMarketSegmentID val)
                {
                    return IsSetPayCollectMarketSegmentID();
                }

                public bool IsSetPayCollectMarketSegmentID()
                {
                    return IsSetField(Tags.PayCollectMarketSegmentID);
                }
                public QuickFix.Fields.PayCollectMarketID PayCollectMarketID
                {
                    get
                    {
                        QuickFix.Fields.PayCollectMarketID val = new QuickFix.Fields.PayCollectMarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PayCollectMarketID val)
                {
                    this.PayCollectMarketID = val;
                }

                public QuickFix.Fields.PayCollectMarketID Get(QuickFix.Fields.PayCollectMarketID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PayCollectMarketID val)
                {
                    return IsSetPayCollectMarketID();
                }

                public bool IsSetPayCollectMarketID()
                {
                    return IsSetField(Tags.PayCollectMarketID);
                }
                public QuickFix.Fields.PayCollectFXRate PayCollectFXRate
                {
                    get
                    {
                        QuickFix.Fields.PayCollectFXRate val = new QuickFix.Fields.PayCollectFXRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PayCollectFXRate val)
                {
                    this.PayCollectFXRate = val;
                }

                public QuickFix.Fields.PayCollectFXRate Get(QuickFix.Fields.PayCollectFXRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PayCollectFXRate val)
                {
                    return IsSetPayCollectFXRate();
                }

                public bool IsSetPayCollectFXRate()
                {
                    return IsSetField(Tags.PayCollectFXRate);
                }
                public QuickFix.Fields.PayCollectFXRateCalc PayCollectFXRateCalc
                {
                    get
                    {
                        QuickFix.Fields.PayCollectFXRateCalc val = new QuickFix.Fields.PayCollectFXRateCalc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PayCollectFXRateCalc val)
                {
                    this.PayCollectFXRateCalc = val;
                }

                public QuickFix.Fields.PayCollectFXRateCalc Get(QuickFix.Fields.PayCollectFXRateCalc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PayCollectFXRateCalc val)
                {
                    return IsSetPayCollectFXRateCalc();
                }

                public bool IsSetPayCollectFXRateCalc()
                {
                    return IsSetField(Tags.PayCollectFXRateCalc);
                }

            }
            public class NoPosAmtGroup : Group
            {
                public static int[] fieldOrder = { Tags.PosAmtType, Tags.PosAmt, Tags.PositionCurrency, Tags.PosAmtReason, Tags.PosAmtStreamDesc, Tags.PositionFXRate, Tags.PositionFXRateCalc, Tags.PosAmtMarketSegmentID, Tags.PosAmtMarketID, Tags.PosAmtPrice, Tags.PosAmtPriceType, 0 };

                public NoPosAmtGroup()
                  : base(Tags.NoPosAmt, Tags.PosAmtType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPosAmtGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.PosAmtType PosAmtType
                {
                    get
                    {
                        QuickFix.Fields.PosAmtType val = new QuickFix.Fields.PosAmtType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmtType val)
                {
                    this.PosAmtType = val;
                }

                public QuickFix.Fields.PosAmtType Get(QuickFix.Fields.PosAmtType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmtType val)
                {
                    return IsSetPosAmtType();
                }

                public bool IsSetPosAmtType()
                {
                    return IsSetField(Tags.PosAmtType);
                }
                public QuickFix.Fields.PosAmt PosAmt
                {
                    get
                    {
                        QuickFix.Fields.PosAmt val = new QuickFix.Fields.PosAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmt val)
                {
                    this.PosAmt = val;
                }

                public QuickFix.Fields.PosAmt Get(QuickFix.Fields.PosAmt val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmt val)
                {
                    return IsSetPosAmt();
                }

                public bool IsSetPosAmt()
                {
                    return IsSetField(Tags.PosAmt);
                }
                public QuickFix.Fields.PositionCurrency PositionCurrency
                {
                    get
                    {
                        QuickFix.Fields.PositionCurrency val = new QuickFix.Fields.PositionCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PositionCurrency val)
                {
                    this.PositionCurrency = val;
                }

                public QuickFix.Fields.PositionCurrency Get(QuickFix.Fields.PositionCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PositionCurrency val)
                {
                    return IsSetPositionCurrency();
                }

                public bool IsSetPositionCurrency()
                {
                    return IsSetField(Tags.PositionCurrency);
                }
                public QuickFix.Fields.PosAmtReason PosAmtReason
                {
                    get
                    {
                        QuickFix.Fields.PosAmtReason val = new QuickFix.Fields.PosAmtReason();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmtReason val)
                {
                    this.PosAmtReason = val;
                }

                public QuickFix.Fields.PosAmtReason Get(QuickFix.Fields.PosAmtReason val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmtReason val)
                {
                    return IsSetPosAmtReason();
                }

                public bool IsSetPosAmtReason()
                {
                    return IsSetField(Tags.PosAmtReason);
                }
                public QuickFix.Fields.PosAmtStreamDesc PosAmtStreamDesc
                {
                    get
                    {
                        QuickFix.Fields.PosAmtStreamDesc val = new QuickFix.Fields.PosAmtStreamDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmtStreamDesc val)
                {
                    this.PosAmtStreamDesc = val;
                }

                public QuickFix.Fields.PosAmtStreamDesc Get(QuickFix.Fields.PosAmtStreamDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmtStreamDesc val)
                {
                    return IsSetPosAmtStreamDesc();
                }

                public bool IsSetPosAmtStreamDesc()
                {
                    return IsSetField(Tags.PosAmtStreamDesc);
                }
                public QuickFix.Fields.PositionFXRate PositionFXRate
                {
                    get
                    {
                        QuickFix.Fields.PositionFXRate val = new QuickFix.Fields.PositionFXRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PositionFXRate val)
                {
                    this.PositionFXRate = val;
                }

                public QuickFix.Fields.PositionFXRate Get(QuickFix.Fields.PositionFXRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PositionFXRate val)
                {
                    return IsSetPositionFXRate();
                }

                public bool IsSetPositionFXRate()
                {
                    return IsSetField(Tags.PositionFXRate);
                }
                public QuickFix.Fields.PositionFXRateCalc PositionFXRateCalc
                {
                    get
                    {
                        QuickFix.Fields.PositionFXRateCalc val = new QuickFix.Fields.PositionFXRateCalc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PositionFXRateCalc val)
                {
                    this.PositionFXRateCalc = val;
                }

                public QuickFix.Fields.PositionFXRateCalc Get(QuickFix.Fields.PositionFXRateCalc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PositionFXRateCalc val)
                {
                    return IsSetPositionFXRateCalc();
                }

                public bool IsSetPositionFXRateCalc()
                {
                    return IsSetField(Tags.PositionFXRateCalc);
                }
                public QuickFix.Fields.PosAmtMarketSegmentID PosAmtMarketSegmentID
                {
                    get
                    {
                        QuickFix.Fields.PosAmtMarketSegmentID val = new QuickFix.Fields.PosAmtMarketSegmentID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmtMarketSegmentID val)
                {
                    this.PosAmtMarketSegmentID = val;
                }

                public QuickFix.Fields.PosAmtMarketSegmentID Get(QuickFix.Fields.PosAmtMarketSegmentID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmtMarketSegmentID val)
                {
                    return IsSetPosAmtMarketSegmentID();
                }

                public bool IsSetPosAmtMarketSegmentID()
                {
                    return IsSetField(Tags.PosAmtMarketSegmentID);
                }
                public QuickFix.Fields.PosAmtMarketID PosAmtMarketID
                {
                    get
                    {
                        QuickFix.Fields.PosAmtMarketID val = new QuickFix.Fields.PosAmtMarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmtMarketID val)
                {
                    this.PosAmtMarketID = val;
                }

                public QuickFix.Fields.PosAmtMarketID Get(QuickFix.Fields.PosAmtMarketID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmtMarketID val)
                {
                    return IsSetPosAmtMarketID();
                }

                public bool IsSetPosAmtMarketID()
                {
                    return IsSetField(Tags.PosAmtMarketID);
                }
                public QuickFix.Fields.PosAmtPrice PosAmtPrice
                {
                    get
                    {
                        QuickFix.Fields.PosAmtPrice val = new QuickFix.Fields.PosAmtPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmtPrice val)
                {
                    this.PosAmtPrice = val;
                }

                public QuickFix.Fields.PosAmtPrice Get(QuickFix.Fields.PosAmtPrice val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmtPrice val)
                {
                    return IsSetPosAmtPrice();
                }

                public bool IsSetPosAmtPrice()
                {
                    return IsSetField(Tags.PosAmtPrice);
                }
                public QuickFix.Fields.PosAmtPriceType PosAmtPriceType
                {
                    get
                    {
                        QuickFix.Fields.PosAmtPriceType val = new QuickFix.Fields.PosAmtPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PosAmtPriceType val)
                {
                    this.PosAmtPriceType = val;
                }

                public QuickFix.Fields.PosAmtPriceType Get(QuickFix.Fields.PosAmtPriceType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PosAmtPriceType val)
                {
                    return IsSetPosAmtPriceType();
                }

                public bool IsSetPosAmtPriceType()
                {
                    return IsSetField(Tags.PosAmtPriceType);
                }

            }
        }
    }
}
