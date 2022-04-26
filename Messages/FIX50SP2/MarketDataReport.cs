// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class MarketDataReport : Message
        {
            public const string MsgType = "DR";

            public MarketDataReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("DR"));
            }

            public MarketDataReport(
                    QuickFix.Fields.MDReportEvent aMDReportEvent,
                    QuickFix.Fields.MDReportCount aMDReportCount
                ) : this()
            {
                this.MDReportEvent = aMDReportEvent;
                this.MDReportCount = aMDReportCount;
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
            public QuickFix.Fields.MDReportID MDReportID
            {
                get
                {
                    QuickFix.Fields.MDReportID val = new QuickFix.Fields.MDReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MDReportID val)
            {
                this.MDReportID = val;
            }

            public QuickFix.Fields.MDReportID Get(QuickFix.Fields.MDReportID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MDReportID val)
            {
                return IsSetMDReportID();
            }

            public bool IsSetMDReportID()
            {
                return IsSetField(Tags.MDReportID);
            }
            public QuickFix.Fields.MDReportEvent MDReportEvent
            {
                get
                {
                    QuickFix.Fields.MDReportEvent val = new QuickFix.Fields.MDReportEvent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MDReportEvent val)
            {
                this.MDReportEvent = val;
            }

            public QuickFix.Fields.MDReportEvent Get(QuickFix.Fields.MDReportEvent val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MDReportEvent val)
            {
                return IsSetMDReportEvent();
            }

            public bool IsSetMDReportEvent()
            {
                return IsSetField(Tags.MDReportEvent);
            }
            public QuickFix.Fields.MDReportCount MDReportCount
            {
                get
                {
                    QuickFix.Fields.MDReportCount val = new QuickFix.Fields.MDReportCount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MDReportCount val)
            {
                this.MDReportCount = val;
            }

            public QuickFix.Fields.MDReportCount Get(QuickFix.Fields.MDReportCount val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MDReportCount val)
            {
                return IsSetMDReportCount();
            }

            public bool IsSetMDReportCount()
            {
                return IsSetField(Tags.MDReportCount);
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
            public QuickFix.Fields.TotNumReports TotNumReports
            {
                get
                {
                    QuickFix.Fields.TotNumReports val = new QuickFix.Fields.TotNumReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNumReports val)
            {
                this.TotNumReports = val;
            }

            public QuickFix.Fields.TotNumReports Get(QuickFix.Fields.TotNumReports val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNumReports val)
            {
                return IsSetTotNumReports();
            }

            public bool IsSetTotNumReports()
            {
                return IsSetField(Tags.TotNumReports);
            }
            public QuickFix.Fields.TotNoMarketSegmentReports TotNoMarketSegmentReports
            {
                get
                {
                    QuickFix.Fields.TotNoMarketSegmentReports val = new QuickFix.Fields.TotNoMarketSegmentReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNoMarketSegmentReports val)
            {
                this.TotNoMarketSegmentReports = val;
            }

            public QuickFix.Fields.TotNoMarketSegmentReports Get(QuickFix.Fields.TotNoMarketSegmentReports val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNoMarketSegmentReports val)
            {
                return IsSetTotNoMarketSegmentReports();
            }

            public bool IsSetTotNoMarketSegmentReports()
            {
                return IsSetField(Tags.TotNoMarketSegmentReports);
            }
            public QuickFix.Fields.TotNoInstrumentReports TotNoInstrumentReports
            {
                get
                {
                    QuickFix.Fields.TotNoInstrumentReports val = new QuickFix.Fields.TotNoInstrumentReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNoInstrumentReports val)
            {
                this.TotNoInstrumentReports = val;
            }

            public QuickFix.Fields.TotNoInstrumentReports Get(QuickFix.Fields.TotNoInstrumentReports val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNoInstrumentReports val)
            {
                return IsSetTotNoInstrumentReports();
            }

            public bool IsSetTotNoInstrumentReports()
            {
                return IsSetField(Tags.TotNoInstrumentReports);
            }
            public QuickFix.Fields.TotNoPartyDetailReports TotNoPartyDetailReports
            {
                get
                {
                    QuickFix.Fields.TotNoPartyDetailReports val = new QuickFix.Fields.TotNoPartyDetailReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNoPartyDetailReports val)
            {
                this.TotNoPartyDetailReports = val;
            }

            public QuickFix.Fields.TotNoPartyDetailReports Get(QuickFix.Fields.TotNoPartyDetailReports val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNoPartyDetailReports val)
            {
                return IsSetTotNoPartyDetailReports();
            }

            public bool IsSetTotNoPartyDetailReports()
            {
                return IsSetField(Tags.TotNoPartyDetailReports);
            }
            public QuickFix.Fields.TotNoEntitlementReports TotNoEntitlementReports
            {
                get
                {
                    QuickFix.Fields.TotNoEntitlementReports val = new QuickFix.Fields.TotNoEntitlementReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNoEntitlementReports val)
            {
                this.TotNoEntitlementReports = val;
            }

            public QuickFix.Fields.TotNoEntitlementReports Get(QuickFix.Fields.TotNoEntitlementReports val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNoEntitlementReports val)
            {
                return IsSetTotNoEntitlementReports();
            }

            public bool IsSetTotNoEntitlementReports()
            {
                return IsSetField(Tags.TotNoEntitlementReports);
            }
            public QuickFix.Fields.TotNoRiskLimitReports TotNoRiskLimitReports
            {
                get
                {
                    QuickFix.Fields.TotNoRiskLimitReports val = new QuickFix.Fields.TotNoRiskLimitReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNoRiskLimitReports val)
            {
                this.TotNoRiskLimitReports = val;
            }

            public QuickFix.Fields.TotNoRiskLimitReports Get(QuickFix.Fields.TotNoRiskLimitReports val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNoRiskLimitReports val)
            {
                return IsSetTotNoRiskLimitReports();
            }

            public bool IsSetTotNoRiskLimitReports()
            {
                return IsSetField(Tags.TotNoRiskLimitReports);
            }
        }
    }
}
