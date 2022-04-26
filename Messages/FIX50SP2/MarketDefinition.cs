// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class MarketDefinition : Message
        {
            public const string MsgType = "BU";

            public MarketDefinition() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BU"));
            }

            public MarketDefinition(
                    QuickFix.Fields.MarketReportID aMarketReportID,
                    QuickFix.Fields.MarketID aMarketID
                ) : this()
            {
                this.MarketReportID = aMarketReportID;
                this.MarketID = aMarketID;
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
            public QuickFix.Fields.MarketReportID MarketReportID
            {
                get
                {
                    QuickFix.Fields.MarketReportID val = new QuickFix.Fields.MarketReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketReportID val)
            {
                this.MarketReportID = val;
            }

            public QuickFix.Fields.MarketReportID Get(QuickFix.Fields.MarketReportID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketReportID val)
            {
                return IsSetMarketReportID();
            }

            public bool IsSetMarketReportID()
            {
                return IsSetField(Tags.MarketReportID);
            }
            public QuickFix.Fields.MarketReqID MarketReqID
            {
                get
                {
                    QuickFix.Fields.MarketReqID val = new QuickFix.Fields.MarketReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketReqID val)
            {
                this.MarketReqID = val;
            }

            public QuickFix.Fields.MarketReqID Get(QuickFix.Fields.MarketReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketReqID val)
            {
                return IsSetMarketReqID();
            }

            public bool IsSetMarketReqID()
            {
                return IsSetField(Tags.MarketReqID);
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
            public QuickFix.Fields.MarketSegmentDesc MarketSegmentDesc
            {
                get
                {
                    QuickFix.Fields.MarketSegmentDesc val = new QuickFix.Fields.MarketSegmentDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketSegmentDesc val)
            {
                this.MarketSegmentDesc = val;
            }

            public QuickFix.Fields.MarketSegmentDesc Get(QuickFix.Fields.MarketSegmentDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketSegmentDesc val)
            {
                return IsSetMarketSegmentDesc();
            }

            public bool IsSetMarketSegmentDesc()
            {
                return IsSetField(Tags.MarketSegmentDesc);
            }
            public QuickFix.Fields.EncodedMktSegmDescLen EncodedMktSegmDescLen
            {
                get
                {
                    QuickFix.Fields.EncodedMktSegmDescLen val = new QuickFix.Fields.EncodedMktSegmDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedMktSegmDescLen val)
            {
                this.EncodedMktSegmDescLen = val;
            }

            public QuickFix.Fields.EncodedMktSegmDescLen Get(QuickFix.Fields.EncodedMktSegmDescLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedMktSegmDescLen val)
            {
                return IsSetEncodedMktSegmDescLen();
            }

            public bool IsSetEncodedMktSegmDescLen()
            {
                return IsSetField(Tags.EncodedMktSegmDescLen);
            }
            public QuickFix.Fields.EncodedMktSegmDesc EncodedMktSegmDesc
            {
                get
                {
                    QuickFix.Fields.EncodedMktSegmDesc val = new QuickFix.Fields.EncodedMktSegmDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedMktSegmDesc val)
            {
                this.EncodedMktSegmDesc = val;
            }

            public QuickFix.Fields.EncodedMktSegmDesc Get(QuickFix.Fields.EncodedMktSegmDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedMktSegmDesc val)
            {
                return IsSetEncodedMktSegmDesc();
            }

            public bool IsSetEncodedMktSegmDesc()
            {
                return IsSetField(Tags.EncodedMktSegmDesc);
            }
            public QuickFix.Fields.ParentMktSegmID ParentMktSegmID
            {
                get
                {
                    QuickFix.Fields.ParentMktSegmID val = new QuickFix.Fields.ParentMktSegmID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ParentMktSegmID val)
            {
                this.ParentMktSegmID = val;
            }

            public QuickFix.Fields.ParentMktSegmID Get(QuickFix.Fields.ParentMktSegmID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ParentMktSegmID val)
            {
                return IsSetParentMktSegmID();
            }

            public bool IsSetParentMktSegmID()
            {
                return IsSetField(Tags.ParentMktSegmID);
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
            public QuickFix.Fields.NoTickRules NoTickRules
            {
                get
                {
                    QuickFix.Fields.NoTickRules val = new QuickFix.Fields.NoTickRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoTickRules val)
            {
                this.NoTickRules = val;
            }

            public QuickFix.Fields.NoTickRules Get(QuickFix.Fields.NoTickRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoTickRules val)
            {
                return IsSetNoTickRules();
            }

            public bool IsSetNoTickRules()
            {
                return IsSetField(Tags.NoTickRules);
            }
            public QuickFix.Fields.NoLotTypeRules NoLotTypeRules
            {
                get
                {
                    QuickFix.Fields.NoLotTypeRules val = new QuickFix.Fields.NoLotTypeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoLotTypeRules val)
            {
                this.NoLotTypeRules = val;
            }

            public QuickFix.Fields.NoLotTypeRules Get(QuickFix.Fields.NoLotTypeRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoLotTypeRules val)
            {
                return IsSetNoLotTypeRules();
            }

            public bool IsSetNoLotTypeRules()
            {
                return IsSetField(Tags.NoLotTypeRules);
            }
            public QuickFix.Fields.PriceLimitType PriceLimitType
            {
                get
                {
                    QuickFix.Fields.PriceLimitType val = new QuickFix.Fields.PriceLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PriceLimitType val)
            {
                this.PriceLimitType = val;
            }

            public QuickFix.Fields.PriceLimitType Get(QuickFix.Fields.PriceLimitType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PriceLimitType val)
            {
                return IsSetPriceLimitType();
            }

            public bool IsSetPriceLimitType()
            {
                return IsSetField(Tags.PriceLimitType);
            }
            public QuickFix.Fields.LowLimitPrice LowLimitPrice
            {
                get
                {
                    QuickFix.Fields.LowLimitPrice val = new QuickFix.Fields.LowLimitPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.LowLimitPrice val)
            {
                this.LowLimitPrice = val;
            }

            public QuickFix.Fields.LowLimitPrice Get(QuickFix.Fields.LowLimitPrice val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.LowLimitPrice val)
            {
                return IsSetLowLimitPrice();
            }

            public bool IsSetLowLimitPrice()
            {
                return IsSetField(Tags.LowLimitPrice);
            }
            public QuickFix.Fields.HighLimitPrice HighLimitPrice
            {
                get
                {
                    QuickFix.Fields.HighLimitPrice val = new QuickFix.Fields.HighLimitPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.HighLimitPrice val)
            {
                this.HighLimitPrice = val;
            }

            public QuickFix.Fields.HighLimitPrice Get(QuickFix.Fields.HighLimitPrice val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.HighLimitPrice val)
            {
                return IsSetHighLimitPrice();
            }

            public bool IsSetHighLimitPrice()
            {
                return IsSetField(Tags.HighLimitPrice);
            }
            public QuickFix.Fields.TradingReferencePrice TradingReferencePrice
            {
                get
                {
                    QuickFix.Fields.TradingReferencePrice val = new QuickFix.Fields.TradingReferencePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradingReferencePrice val)
            {
                this.TradingReferencePrice = val;
            }

            public QuickFix.Fields.TradingReferencePrice Get(QuickFix.Fields.TradingReferencePrice val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradingReferencePrice val)
            {
                return IsSetTradingReferencePrice();
            }

            public bool IsSetTradingReferencePrice()
            {
                return IsSetField(Tags.TradingReferencePrice);
            }
            public QuickFix.Fields.ExpirationCycle ExpirationCycle
            {
                get
                {
                    QuickFix.Fields.ExpirationCycle val = new QuickFix.Fields.ExpirationCycle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ExpirationCycle val)
            {
                this.ExpirationCycle = val;
            }

            public QuickFix.Fields.ExpirationCycle Get(QuickFix.Fields.ExpirationCycle val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ExpirationCycle val)
            {
                return IsSetExpirationCycle();
            }

            public bool IsSetExpirationCycle()
            {
                return IsSetField(Tags.ExpirationCycle);
            }
            public QuickFix.Fields.MinTradeVol MinTradeVol
            {
                get
                {
                    QuickFix.Fields.MinTradeVol val = new QuickFix.Fields.MinTradeVol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MinTradeVol val)
            {
                this.MinTradeVol = val;
            }

            public QuickFix.Fields.MinTradeVol Get(QuickFix.Fields.MinTradeVol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MinTradeVol val)
            {
                return IsSetMinTradeVol();
            }

            public bool IsSetMinTradeVol()
            {
                return IsSetField(Tags.MinTradeVol);
            }
            public QuickFix.Fields.MaxTradeVol MaxTradeVol
            {
                get
                {
                    QuickFix.Fields.MaxTradeVol val = new QuickFix.Fields.MaxTradeVol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaxTradeVol val)
            {
                this.MaxTradeVol = val;
            }

            public QuickFix.Fields.MaxTradeVol Get(QuickFix.Fields.MaxTradeVol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaxTradeVol val)
            {
                return IsSetMaxTradeVol();
            }

            public bool IsSetMaxTradeVol()
            {
                return IsSetField(Tags.MaxTradeVol);
            }
            public QuickFix.Fields.MaxPriceVariation MaxPriceVariation
            {
                get
                {
                    QuickFix.Fields.MaxPriceVariation val = new QuickFix.Fields.MaxPriceVariation();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaxPriceVariation val)
            {
                this.MaxPriceVariation = val;
            }

            public QuickFix.Fields.MaxPriceVariation Get(QuickFix.Fields.MaxPriceVariation val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaxPriceVariation val)
            {
                return IsSetMaxPriceVariation();
            }

            public bool IsSetMaxPriceVariation()
            {
                return IsSetField(Tags.MaxPriceVariation);
            }
            public QuickFix.Fields.ImpliedMarketIndicator ImpliedMarketIndicator
            {
                get
                {
                    QuickFix.Fields.ImpliedMarketIndicator val = new QuickFix.Fields.ImpliedMarketIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ImpliedMarketIndicator val)
            {
                this.ImpliedMarketIndicator = val;
            }

            public QuickFix.Fields.ImpliedMarketIndicator Get(QuickFix.Fields.ImpliedMarketIndicator val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ImpliedMarketIndicator val)
            {
                return IsSetImpliedMarketIndicator();
            }

            public bool IsSetImpliedMarketIndicator()
            {
                return IsSetField(Tags.ImpliedMarketIndicator);
            }
            public QuickFix.Fields.TradingCurrency TradingCurrency
            {
                get
                {
                    QuickFix.Fields.TradingCurrency val = new QuickFix.Fields.TradingCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradingCurrency val)
            {
                this.TradingCurrency = val;
            }

            public QuickFix.Fields.TradingCurrency Get(QuickFix.Fields.TradingCurrency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradingCurrency val)
            {
                return IsSetTradingCurrency();
            }

            public bool IsSetTradingCurrency()
            {
                return IsSetField(Tags.TradingCurrency);
            }
            public QuickFix.Fields.RoundLot RoundLot
            {
                get
                {
                    QuickFix.Fields.RoundLot val = new QuickFix.Fields.RoundLot();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RoundLot val)
            {
                this.RoundLot = val;
            }

            public QuickFix.Fields.RoundLot Get(QuickFix.Fields.RoundLot val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RoundLot val)
            {
                return IsSetRoundLot();
            }

            public bool IsSetRoundLot()
            {
                return IsSetField(Tags.RoundLot);
            }
            public QuickFix.Fields.MultilegModel MultilegModel
            {
                get
                {
                    QuickFix.Fields.MultilegModel val = new QuickFix.Fields.MultilegModel();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MultilegModel val)
            {
                this.MultilegModel = val;
            }

            public QuickFix.Fields.MultilegModel Get(QuickFix.Fields.MultilegModel val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MultilegModel val)
            {
                return IsSetMultilegModel();
            }

            public bool IsSetMultilegModel()
            {
                return IsSetField(Tags.MultilegModel);
            }
            public QuickFix.Fields.MultilegPriceMethod MultilegPriceMethod
            {
                get
                {
                    QuickFix.Fields.MultilegPriceMethod val = new QuickFix.Fields.MultilegPriceMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MultilegPriceMethod val)
            {
                this.MultilegPriceMethod = val;
            }

            public QuickFix.Fields.MultilegPriceMethod Get(QuickFix.Fields.MultilegPriceMethod val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MultilegPriceMethod val)
            {
                return IsSetMultilegPriceMethod();
            }

            public bool IsSetMultilegPriceMethod()
            {
                return IsSetField(Tags.MultilegPriceMethod);
            }
            public QuickFix.Fields.PriceType PriceType
            {
                get
                {
                    QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PriceType val)
            {
                this.PriceType = val;
            }

            public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PriceType val)
            {
                return IsSetPriceType();
            }

            public bool IsSetPriceType()
            {
                return IsSetField(Tags.PriceType);
            }
            public QuickFix.Fields.TradeVolType TradeVolType
            {
                get
                {
                    QuickFix.Fields.TradeVolType val = new QuickFix.Fields.TradeVolType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradeVolType val)
            {
                this.TradeVolType = val;
            }

            public QuickFix.Fields.TradeVolType Get(QuickFix.Fields.TradeVolType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradeVolType val)
            {
                return IsSetTradeVolType();
            }

            public bool IsSetTradeVolType()
            {
                return IsSetField(Tags.TradeVolType);
            }
            public QuickFix.Fields.NoPriceRangeRules NoPriceRangeRules
            {
                get
                {
                    QuickFix.Fields.NoPriceRangeRules val = new QuickFix.Fields.NoPriceRangeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPriceRangeRules val)
            {
                this.NoPriceRangeRules = val;
            }

            public QuickFix.Fields.NoPriceRangeRules Get(QuickFix.Fields.NoPriceRangeRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPriceRangeRules val)
            {
                return IsSetNoPriceRangeRules();
            }

            public bool IsSetNoPriceRangeRules()
            {
                return IsSetField(Tags.NoPriceRangeRules);
            }
            public QuickFix.Fields.NoQuoteSizeRules NoQuoteSizeRules
            {
                get
                {
                    QuickFix.Fields.NoQuoteSizeRules val = new QuickFix.Fields.NoQuoteSizeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoQuoteSizeRules val)
            {
                this.NoQuoteSizeRules = val;
            }

            public QuickFix.Fields.NoQuoteSizeRules Get(QuickFix.Fields.NoQuoteSizeRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoQuoteSizeRules val)
            {
                return IsSetNoQuoteSizeRules();
            }

            public bool IsSetNoQuoteSizeRules()
            {
                return IsSetField(Tags.NoQuoteSizeRules);
            }
            public QuickFix.Fields.FastMarketPercentage FastMarketPercentage
            {
                get
                {
                    QuickFix.Fields.FastMarketPercentage val = new QuickFix.Fields.FastMarketPercentage();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.FastMarketPercentage val)
            {
                this.FastMarketPercentage = val;
            }

            public QuickFix.Fields.FastMarketPercentage Get(QuickFix.Fields.FastMarketPercentage val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.FastMarketPercentage val)
            {
                return IsSetFastMarketPercentage();
            }

            public bool IsSetFastMarketPercentage()
            {
                return IsSetField(Tags.FastMarketPercentage);
            }
            public QuickFix.Fields.QuoteSideIndicator QuoteSideIndicator
            {
                get
                {
                    QuickFix.Fields.QuoteSideIndicator val = new QuickFix.Fields.QuoteSideIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteSideIndicator val)
            {
                this.QuoteSideIndicator = val;
            }

            public QuickFix.Fields.QuoteSideIndicator Get(QuickFix.Fields.QuoteSideIndicator val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteSideIndicator val)
            {
                return IsSetQuoteSideIndicator();
            }

            public bool IsSetQuoteSideIndicator()
            {
                return IsSetField(Tags.QuoteSideIndicator);
            }
            public QuickFix.Fields.NoOrdTypeRules NoOrdTypeRules
            {
                get
                {
                    QuickFix.Fields.NoOrdTypeRules val = new QuickFix.Fields.NoOrdTypeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoOrdTypeRules val)
            {
                this.NoOrdTypeRules = val;
            }

            public QuickFix.Fields.NoOrdTypeRules Get(QuickFix.Fields.NoOrdTypeRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoOrdTypeRules val)
            {
                return IsSetNoOrdTypeRules();
            }

            public bool IsSetNoOrdTypeRules()
            {
                return IsSetField(Tags.NoOrdTypeRules);
            }
            public QuickFix.Fields.NoTimeInForceRules NoTimeInForceRules
            {
                get
                {
                    QuickFix.Fields.NoTimeInForceRules val = new QuickFix.Fields.NoTimeInForceRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoTimeInForceRules val)
            {
                this.NoTimeInForceRules = val;
            }

            public QuickFix.Fields.NoTimeInForceRules Get(QuickFix.Fields.NoTimeInForceRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoTimeInForceRules val)
            {
                return IsSetNoTimeInForceRules();
            }

            public bool IsSetNoTimeInForceRules()
            {
                return IsSetField(Tags.NoTimeInForceRules);
            }
            public QuickFix.Fields.NoExecInstRules NoExecInstRules
            {
                get
                {
                    QuickFix.Fields.NoExecInstRules val = new QuickFix.Fields.NoExecInstRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoExecInstRules val)
            {
                this.NoExecInstRules = val;
            }

            public QuickFix.Fields.NoExecInstRules Get(QuickFix.Fields.NoExecInstRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoExecInstRules val)
            {
                return IsSetNoExecInstRules();
            }

            public bool IsSetNoExecInstRules()
            {
                return IsSetField(Tags.NoExecInstRules);
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
            public QuickFix.Fields.MarketSegmentStatus MarketSegmentStatus
            {
                get
                {
                    QuickFix.Fields.MarketSegmentStatus val = new QuickFix.Fields.MarketSegmentStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketSegmentStatus val)
            {
                this.MarketSegmentStatus = val;
            }

            public QuickFix.Fields.MarketSegmentStatus Get(QuickFix.Fields.MarketSegmentStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketSegmentStatus val)
            {
                return IsSetMarketSegmentStatus();
            }

            public bool IsSetMarketSegmentStatus()
            {
                return IsSetField(Tags.MarketSegmentStatus);
            }
            public QuickFix.Fields.MarketSegmentType MarketSegmentType
            {
                get
                {
                    QuickFix.Fields.MarketSegmentType val = new QuickFix.Fields.MarketSegmentType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketSegmentType val)
            {
                this.MarketSegmentType = val;
            }

            public QuickFix.Fields.MarketSegmentType Get(QuickFix.Fields.MarketSegmentType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketSegmentType val)
            {
                return IsSetMarketSegmentType();
            }

            public bool IsSetMarketSegmentType()
            {
                return IsSetField(Tags.MarketSegmentType);
            }
            public QuickFix.Fields.MarketSegmentSubType MarketSegmentSubType
            {
                get
                {
                    QuickFix.Fields.MarketSegmentSubType val = new QuickFix.Fields.MarketSegmentSubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketSegmentSubType val)
            {
                this.MarketSegmentSubType = val;
            }

            public QuickFix.Fields.MarketSegmentSubType Get(QuickFix.Fields.MarketSegmentSubType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketSegmentSubType val)
            {
                return IsSetMarketSegmentSubType();
            }

            public bool IsSetMarketSegmentSubType()
            {
                return IsSetField(Tags.MarketSegmentSubType);
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
            public QuickFix.Fields.NoRelatedMarketSegments NoRelatedMarketSegments
            {
                get
                {
                    QuickFix.Fields.NoRelatedMarketSegments val = new QuickFix.Fields.NoRelatedMarketSegments();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoRelatedMarketSegments val)
            {
                this.NoRelatedMarketSegments = val;
            }

            public QuickFix.Fields.NoRelatedMarketSegments Get(QuickFix.Fields.NoRelatedMarketSegments val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoRelatedMarketSegments val)
            {
                return IsSetNoRelatedMarketSegments();
            }

            public bool IsSetNoRelatedMarketSegments()
            {
                return IsSetField(Tags.NoRelatedMarketSegments);
            }
            public QuickFix.Fields.NoAuctionTypeRules NoAuctionTypeRules
            {
                get
                {
                    QuickFix.Fields.NoAuctionTypeRules val = new QuickFix.Fields.NoAuctionTypeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoAuctionTypeRules val)
            {
                this.NoAuctionTypeRules = val;
            }

            public QuickFix.Fields.NoAuctionTypeRules Get(QuickFix.Fields.NoAuctionTypeRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoAuctionTypeRules val)
            {
                return IsSetNoAuctionTypeRules();
            }

            public bool IsSetNoAuctionTypeRules()
            {
                return IsSetField(Tags.NoAuctionTypeRules);
            }
            public QuickFix.Fields.NoMDFeedTypes NoMDFeedTypes
            {
                get
                {
                    QuickFix.Fields.NoMDFeedTypes val = new QuickFix.Fields.NoMDFeedTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMDFeedTypes val)
            {
                this.NoMDFeedTypes = val;
            }

            public QuickFix.Fields.NoMDFeedTypes Get(QuickFix.Fields.NoMDFeedTypes val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMDFeedTypes val)
            {
                return IsSetNoMDFeedTypes();
            }

            public bool IsSetNoMDFeedTypes()
            {
                return IsSetField(Tags.NoMDFeedTypes);
            }
            public QuickFix.Fields.NoMatchRules NoMatchRules
            {
                get
                {
                    QuickFix.Fields.NoMatchRules val = new QuickFix.Fields.NoMatchRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMatchRules val)
            {
                this.NoMatchRules = val;
            }

            public QuickFix.Fields.NoMatchRules Get(QuickFix.Fields.NoMatchRules val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMatchRules val)
            {
                return IsSetNoMatchRules();
            }

            public bool IsSetNoMatchRules()
            {
                return IsSetField(Tags.NoMatchRules);
            }
            public QuickFix.Fields.NoFlexProductEligibilities NoFlexProductEligibilities
            {
                get
                {
                    QuickFix.Fields.NoFlexProductEligibilities val = new QuickFix.Fields.NoFlexProductEligibilities();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoFlexProductEligibilities val)
            {
                this.NoFlexProductEligibilities = val;
            }

            public QuickFix.Fields.NoFlexProductEligibilities Get(QuickFix.Fields.NoFlexProductEligibilities val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoFlexProductEligibilities val)
            {
                return IsSetNoFlexProductEligibilities();
            }

            public bool IsSetNoFlexProductEligibilities()
            {
                return IsSetField(Tags.NoFlexProductEligibilities);
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
            public QuickFix.Fields.EffectiveBusinessDate EffectiveBusinessDate
            {
                get
                {
                    QuickFix.Fields.EffectiveBusinessDate val = new QuickFix.Fields.EffectiveBusinessDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EffectiveBusinessDate val)
            {
                this.EffectiveBusinessDate = val;
            }

            public QuickFix.Fields.EffectiveBusinessDate Get(QuickFix.Fields.EffectiveBusinessDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EffectiveBusinessDate val)
            {
                return IsSetEffectiveBusinessDate();
            }

            public bool IsSetEffectiveBusinessDate()
            {
                return IsSetField(Tags.EffectiveBusinessDate);
            }
            public QuickFix.Fields.NoMiscFees NoMiscFees
            {
                get
                {
                    QuickFix.Fields.NoMiscFees val = new QuickFix.Fields.NoMiscFees();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMiscFees val)
            {
                this.NoMiscFees = val;
            }

            public QuickFix.Fields.NoMiscFees Get(QuickFix.Fields.NoMiscFees val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMiscFees val)
            {
                return IsSetNoMiscFees();
            }

            public bool IsSetNoMiscFees()
            {
                return IsSetField(Tags.NoMiscFees);
            }
            public class NoTickRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, Tags.SettlPriceIncrement, Tags.SettlPriceSecondaryIncrement, Tags.TickRuleProductComplex, 0 };

                public NoTickRulesGroup()
                  : base(Tags.NoTickRules, Tags.StartTickPriceRange, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoTickRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.StartTickPriceRange StartTickPriceRange
                {
                    get
                    {
                        QuickFix.Fields.StartTickPriceRange val = new QuickFix.Fields.StartTickPriceRange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.StartTickPriceRange val)
                {
                    this.StartTickPriceRange = val;
                }

                public QuickFix.Fields.StartTickPriceRange Get(QuickFix.Fields.StartTickPriceRange val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.StartTickPriceRange val)
                {
                    return IsSetStartTickPriceRange();
                }

                public bool IsSetStartTickPriceRange()
                {
                    return IsSetField(Tags.StartTickPriceRange);
                }
                public QuickFix.Fields.EndTickPriceRange EndTickPriceRange
                {
                    get
                    {
                        QuickFix.Fields.EndTickPriceRange val = new QuickFix.Fields.EndTickPriceRange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EndTickPriceRange val)
                {
                    this.EndTickPriceRange = val;
                }

                public QuickFix.Fields.EndTickPriceRange Get(QuickFix.Fields.EndTickPriceRange val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EndTickPriceRange val)
                {
                    return IsSetEndTickPriceRange();
                }

                public bool IsSetEndTickPriceRange()
                {
                    return IsSetField(Tags.EndTickPriceRange);
                }
                public QuickFix.Fields.TickIncrement TickIncrement
                {
                    get
                    {
                        QuickFix.Fields.TickIncrement val = new QuickFix.Fields.TickIncrement();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TickIncrement val)
                {
                    this.TickIncrement = val;
                }

                public QuickFix.Fields.TickIncrement Get(QuickFix.Fields.TickIncrement val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TickIncrement val)
                {
                    return IsSetTickIncrement();
                }

                public bool IsSetTickIncrement()
                {
                    return IsSetField(Tags.TickIncrement);
                }
                public QuickFix.Fields.TickRuleType TickRuleType
                {
                    get
                    {
                        QuickFix.Fields.TickRuleType val = new QuickFix.Fields.TickRuleType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TickRuleType val)
                {
                    this.TickRuleType = val;
                }

                public QuickFix.Fields.TickRuleType Get(QuickFix.Fields.TickRuleType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TickRuleType val)
                {
                    return IsSetTickRuleType();
                }

                public bool IsSetTickRuleType()
                {
                    return IsSetField(Tags.TickRuleType);
                }
                public QuickFix.Fields.SettlPriceIncrement SettlPriceIncrement
                {
                    get
                    {
                        QuickFix.Fields.SettlPriceIncrement val = new QuickFix.Fields.SettlPriceIncrement();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlPriceIncrement val)
                {
                    this.SettlPriceIncrement = val;
                }

                public QuickFix.Fields.SettlPriceIncrement Get(QuickFix.Fields.SettlPriceIncrement val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlPriceIncrement val)
                {
                    return IsSetSettlPriceIncrement();
                }

                public bool IsSetSettlPriceIncrement()
                {
                    return IsSetField(Tags.SettlPriceIncrement);
                }
                public QuickFix.Fields.SettlPriceSecondaryIncrement SettlPriceSecondaryIncrement
                {
                    get
                    {
                        QuickFix.Fields.SettlPriceSecondaryIncrement val = new QuickFix.Fields.SettlPriceSecondaryIncrement();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlPriceSecondaryIncrement val)
                {
                    this.SettlPriceSecondaryIncrement = val;
                }

                public QuickFix.Fields.SettlPriceSecondaryIncrement Get(QuickFix.Fields.SettlPriceSecondaryIncrement val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlPriceSecondaryIncrement val)
                {
                    return IsSetSettlPriceSecondaryIncrement();
                }

                public bool IsSetSettlPriceSecondaryIncrement()
                {
                    return IsSetField(Tags.SettlPriceSecondaryIncrement);
                }
                public QuickFix.Fields.TickRuleProductComplex TickRuleProductComplex
                {
                    get
                    {
                        QuickFix.Fields.TickRuleProductComplex val = new QuickFix.Fields.TickRuleProductComplex();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TickRuleProductComplex val)
                {
                    this.TickRuleProductComplex = val;
                }

                public QuickFix.Fields.TickRuleProductComplex Get(QuickFix.Fields.TickRuleProductComplex val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TickRuleProductComplex val)
                {
                    return IsSetTickRuleProductComplex();
                }

                public bool IsSetTickRuleProductComplex()
                {
                    return IsSetField(Tags.TickRuleProductComplex);
                }

            }
            public class NoLotTypeRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.LotType, Tags.MinLotSize, 0 };

                public NoLotTypeRulesGroup()
                  : base(Tags.NoLotTypeRules, Tags.LotType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoLotTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.LotType LotType
                {
                    get
                    {
                        QuickFix.Fields.LotType val = new QuickFix.Fields.LotType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LotType val)
                {
                    this.LotType = val;
                }

                public QuickFix.Fields.LotType Get(QuickFix.Fields.LotType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LotType val)
                {
                    return IsSetLotType();
                }

                public bool IsSetLotType()
                {
                    return IsSetField(Tags.LotType);
                }
                public QuickFix.Fields.MinLotSize MinLotSize
                {
                    get
                    {
                        QuickFix.Fields.MinLotSize val = new QuickFix.Fields.MinLotSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MinLotSize val)
                {
                    this.MinLotSize = val;
                }

                public QuickFix.Fields.MinLotSize Get(QuickFix.Fields.MinLotSize val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MinLotSize val)
                {
                    return IsSetMinLotSize();
                }

                public bool IsSetMinLotSize()
                {
                    return IsSetField(Tags.MinLotSize);
                }

            }
            public class NoPriceRangeRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.StartPriceRange, Tags.EndPriceRange, Tags.PriceRangeValue, Tags.PriceRangePercentage, Tags.PriceRangeRuleID, Tags.PriceRangeProductComplex, 0 };

                public NoPriceRangeRulesGroup()
                  : base(Tags.NoPriceRangeRules, Tags.StartPriceRange, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPriceRangeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.StartPriceRange StartPriceRange
                {
                    get
                    {
                        QuickFix.Fields.StartPriceRange val = new QuickFix.Fields.StartPriceRange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.StartPriceRange val)
                {
                    this.StartPriceRange = val;
                }

                public QuickFix.Fields.StartPriceRange Get(QuickFix.Fields.StartPriceRange val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.StartPriceRange val)
                {
                    return IsSetStartPriceRange();
                }

                public bool IsSetStartPriceRange()
                {
                    return IsSetField(Tags.StartPriceRange);
                }
                public QuickFix.Fields.EndPriceRange EndPriceRange
                {
                    get
                    {
                        QuickFix.Fields.EndPriceRange val = new QuickFix.Fields.EndPriceRange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EndPriceRange val)
                {
                    this.EndPriceRange = val;
                }

                public QuickFix.Fields.EndPriceRange Get(QuickFix.Fields.EndPriceRange val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EndPriceRange val)
                {
                    return IsSetEndPriceRange();
                }

                public bool IsSetEndPriceRange()
                {
                    return IsSetField(Tags.EndPriceRange);
                }
                public QuickFix.Fields.PriceRangeValue PriceRangeValue
                {
                    get
                    {
                        QuickFix.Fields.PriceRangeValue val = new QuickFix.Fields.PriceRangeValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PriceRangeValue val)
                {
                    this.PriceRangeValue = val;
                }

                public QuickFix.Fields.PriceRangeValue Get(QuickFix.Fields.PriceRangeValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PriceRangeValue val)
                {
                    return IsSetPriceRangeValue();
                }

                public bool IsSetPriceRangeValue()
                {
                    return IsSetField(Tags.PriceRangeValue);
                }
                public QuickFix.Fields.PriceRangePercentage PriceRangePercentage
                {
                    get
                    {
                        QuickFix.Fields.PriceRangePercentage val = new QuickFix.Fields.PriceRangePercentage();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PriceRangePercentage val)
                {
                    this.PriceRangePercentage = val;
                }

                public QuickFix.Fields.PriceRangePercentage Get(QuickFix.Fields.PriceRangePercentage val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PriceRangePercentage val)
                {
                    return IsSetPriceRangePercentage();
                }

                public bool IsSetPriceRangePercentage()
                {
                    return IsSetField(Tags.PriceRangePercentage);
                }
                public QuickFix.Fields.PriceRangeRuleID PriceRangeRuleID
                {
                    get
                    {
                        QuickFix.Fields.PriceRangeRuleID val = new QuickFix.Fields.PriceRangeRuleID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PriceRangeRuleID val)
                {
                    this.PriceRangeRuleID = val;
                }

                public QuickFix.Fields.PriceRangeRuleID Get(QuickFix.Fields.PriceRangeRuleID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PriceRangeRuleID val)
                {
                    return IsSetPriceRangeRuleID();
                }

                public bool IsSetPriceRangeRuleID()
                {
                    return IsSetField(Tags.PriceRangeRuleID);
                }
                public QuickFix.Fields.PriceRangeProductComplex PriceRangeProductComplex
                {
                    get
                    {
                        QuickFix.Fields.PriceRangeProductComplex val = new QuickFix.Fields.PriceRangeProductComplex();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PriceRangeProductComplex val)
                {
                    this.PriceRangeProductComplex = val;
                }

                public QuickFix.Fields.PriceRangeProductComplex Get(QuickFix.Fields.PriceRangeProductComplex val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PriceRangeProductComplex val)
                {
                    return IsSetPriceRangeProductComplex();
                }

                public bool IsSetPriceRangeProductComplex()
                {
                    return IsSetField(Tags.PriceRangeProductComplex);
                }

            }
            public class NoQuoteSizeRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.MinBidSize, Tags.MinOfferSize, Tags.FastMarketIndicator, 0 };

                public NoQuoteSizeRulesGroup()
                  : base(Tags.NoQuoteSizeRules, Tags.MinBidSize, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoQuoteSizeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MinBidSize MinBidSize
                {
                    get
                    {
                        QuickFix.Fields.MinBidSize val = new QuickFix.Fields.MinBidSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MinBidSize val)
                {
                    this.MinBidSize = val;
                }

                public QuickFix.Fields.MinBidSize Get(QuickFix.Fields.MinBidSize val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MinBidSize val)
                {
                    return IsSetMinBidSize();
                }

                public bool IsSetMinBidSize()
                {
                    return IsSetField(Tags.MinBidSize);
                }
                public QuickFix.Fields.MinOfferSize MinOfferSize
                {
                    get
                    {
                        QuickFix.Fields.MinOfferSize val = new QuickFix.Fields.MinOfferSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MinOfferSize val)
                {
                    this.MinOfferSize = val;
                }

                public QuickFix.Fields.MinOfferSize Get(QuickFix.Fields.MinOfferSize val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MinOfferSize val)
                {
                    return IsSetMinOfferSize();
                }

                public bool IsSetMinOfferSize()
                {
                    return IsSetField(Tags.MinOfferSize);
                }
                public QuickFix.Fields.FastMarketIndicator FastMarketIndicator
                {
                    get
                    {
                        QuickFix.Fields.FastMarketIndicator val = new QuickFix.Fields.FastMarketIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.FastMarketIndicator val)
                {
                    this.FastMarketIndicator = val;
                }

                public QuickFix.Fields.FastMarketIndicator Get(QuickFix.Fields.FastMarketIndicator val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.FastMarketIndicator val)
                {
                    return IsSetFastMarketIndicator();
                }

                public bool IsSetFastMarketIndicator()
                {
                    return IsSetField(Tags.FastMarketIndicator);
                }

            }
            public class NoOrdTypeRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.OrdType, 0 };

                public NoOrdTypeRulesGroup()
                  : base(Tags.NoOrdTypeRules, Tags.OrdType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoOrdTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.OrdType OrdType
                {
                    get
                    {
                        QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.OrdType val)
                {
                    this.OrdType = val;
                }

                public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.OrdType val)
                {
                    return IsSetOrdType();
                }

                public bool IsSetOrdType()
                {
                    return IsSetField(Tags.OrdType);
                }

            }
            public class NoTimeInForceRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.TimeInForce, 0 };

                public NoTimeInForceRulesGroup()
                  : base(Tags.NoTimeInForceRules, Tags.TimeInForce, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoTimeInForceRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.TimeInForce TimeInForce
                {
                    get
                    {
                        QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TimeInForce val)
                {
                    this.TimeInForce = val;
                }

                public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TimeInForce val)
                {
                    return IsSetTimeInForce();
                }

                public bool IsSetTimeInForce()
                {
                    return IsSetField(Tags.TimeInForce);
                }

            }
            public class NoExecInstRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.ExecInstValue, 0 };

                public NoExecInstRulesGroup()
                  : base(Tags.NoExecInstRules, Tags.ExecInstValue, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoExecInstRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.ExecInstValue ExecInstValue
                {
                    get
                    {
                        QuickFix.Fields.ExecInstValue val = new QuickFix.Fields.ExecInstValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ExecInstValue val)
                {
                    this.ExecInstValue = val;
                }

                public QuickFix.Fields.ExecInstValue Get(QuickFix.Fields.ExecInstValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ExecInstValue val)
                {
                    return IsSetExecInstValue();
                }

                public bool IsSetExecInstValue()
                {
                    return IsSetField(Tags.ExecInstValue);
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
            public class NoRelatedMarketSegmentsGroup : Group
            {
                public static int[] fieldOrder = { Tags.RelatedMarketSegmentID, Tags.MarketSegmentRelationship, 0 };

                public NoRelatedMarketSegmentsGroup()
                  : base(Tags.NoRelatedMarketSegments, Tags.RelatedMarketSegmentID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRelatedMarketSegmentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.RelatedMarketSegmentID RelatedMarketSegmentID
                {
                    get
                    {
                        QuickFix.Fields.RelatedMarketSegmentID val = new QuickFix.Fields.RelatedMarketSegmentID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RelatedMarketSegmentID val)
                {
                    this.RelatedMarketSegmentID = val;
                }

                public QuickFix.Fields.RelatedMarketSegmentID Get(QuickFix.Fields.RelatedMarketSegmentID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RelatedMarketSegmentID val)
                {
                    return IsSetRelatedMarketSegmentID();
                }

                public bool IsSetRelatedMarketSegmentID()
                {
                    return IsSetField(Tags.RelatedMarketSegmentID);
                }
                public QuickFix.Fields.MarketSegmentRelationship MarketSegmentRelationship
                {
                    get
                    {
                        QuickFix.Fields.MarketSegmentRelationship val = new QuickFix.Fields.MarketSegmentRelationship();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarketSegmentRelationship val)
                {
                    this.MarketSegmentRelationship = val;
                }

                public QuickFix.Fields.MarketSegmentRelationship Get(QuickFix.Fields.MarketSegmentRelationship val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarketSegmentRelationship val)
                {
                    return IsSetMarketSegmentRelationship();
                }

                public bool IsSetMarketSegmentRelationship()
                {
                    return IsSetField(Tags.MarketSegmentRelationship);
                }

            }
            public class NoAuctionTypeRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.AuctionType, Tags.AuctionTypeProductComplex, 0 };

                public NoAuctionTypeRulesGroup()
                  : base(Tags.NoAuctionTypeRules, Tags.AuctionType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoAuctionTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.AuctionType AuctionType
                {
                    get
                    {
                        QuickFix.Fields.AuctionType val = new QuickFix.Fields.AuctionType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.AuctionType val)
                {
                    this.AuctionType = val;
                }

                public QuickFix.Fields.AuctionType Get(QuickFix.Fields.AuctionType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.AuctionType val)
                {
                    return IsSetAuctionType();
                }

                public bool IsSetAuctionType()
                {
                    return IsSetField(Tags.AuctionType);
                }
                public QuickFix.Fields.AuctionTypeProductComplex AuctionTypeProductComplex
                {
                    get
                    {
                        QuickFix.Fields.AuctionTypeProductComplex val = new QuickFix.Fields.AuctionTypeProductComplex();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.AuctionTypeProductComplex val)
                {
                    this.AuctionTypeProductComplex = val;
                }

                public QuickFix.Fields.AuctionTypeProductComplex Get(QuickFix.Fields.AuctionTypeProductComplex val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.AuctionTypeProductComplex val)
                {
                    return IsSetAuctionTypeProductComplex();
                }

                public bool IsSetAuctionTypeProductComplex()
                {
                    return IsSetField(Tags.AuctionTypeProductComplex);
                }

            }
            public class NoMDFeedTypesGroup : Group
            {
                public static int[] fieldOrder = { Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, Tags.MDSubFeedType, Tags.MarketDepthTimeInterval, Tags.MarketDepthTimeIntervalUnit, Tags.MDRecoveryTimeInterval, Tags.MDRecoveryTimeIntervalUnit, Tags.MDSubBookType, Tags.PrimaryServiceLocationID, Tags.SecondaryServiceLocationID, 0 };

                public NoMDFeedTypesGroup()
                  : base(Tags.NoMDFeedTypes, Tags.MDFeedType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMDFeedTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MDFeedType MDFeedType
                {
                    get
                    {
                        QuickFix.Fields.MDFeedType val = new QuickFix.Fields.MDFeedType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDFeedType val)
                {
                    this.MDFeedType = val;
                }

                public QuickFix.Fields.MDFeedType Get(QuickFix.Fields.MDFeedType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDFeedType val)
                {
                    return IsSetMDFeedType();
                }

                public bool IsSetMDFeedType()
                {
                    return IsSetField(Tags.MDFeedType);
                }
                public QuickFix.Fields.MarketDepth MarketDepth
                {
                    get
                    {
                        QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarketDepth val)
                {
                    this.MarketDepth = val;
                }

                public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarketDepth val)
                {
                    return IsSetMarketDepth();
                }

                public bool IsSetMarketDepth()
                {
                    return IsSetField(Tags.MarketDepth);
                }
                public QuickFix.Fields.MDBookType MDBookType
                {
                    get
                    {
                        QuickFix.Fields.MDBookType val = new QuickFix.Fields.MDBookType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDBookType val)
                {
                    this.MDBookType = val;
                }

                public QuickFix.Fields.MDBookType Get(QuickFix.Fields.MDBookType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDBookType val)
                {
                    return IsSetMDBookType();
                }

                public bool IsSetMDBookType()
                {
                    return IsSetField(Tags.MDBookType);
                }
                public QuickFix.Fields.MDSubFeedType MDSubFeedType
                {
                    get
                    {
                        QuickFix.Fields.MDSubFeedType val = new QuickFix.Fields.MDSubFeedType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDSubFeedType val)
                {
                    this.MDSubFeedType = val;
                }

                public QuickFix.Fields.MDSubFeedType Get(QuickFix.Fields.MDSubFeedType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDSubFeedType val)
                {
                    return IsSetMDSubFeedType();
                }

                public bool IsSetMDSubFeedType()
                {
                    return IsSetField(Tags.MDSubFeedType);
                }
                public QuickFix.Fields.MarketDepthTimeInterval MarketDepthTimeInterval
                {
                    get
                    {
                        QuickFix.Fields.MarketDepthTimeInterval val = new QuickFix.Fields.MarketDepthTimeInterval();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarketDepthTimeInterval val)
                {
                    this.MarketDepthTimeInterval = val;
                }

                public QuickFix.Fields.MarketDepthTimeInterval Get(QuickFix.Fields.MarketDepthTimeInterval val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarketDepthTimeInterval val)
                {
                    return IsSetMarketDepthTimeInterval();
                }

                public bool IsSetMarketDepthTimeInterval()
                {
                    return IsSetField(Tags.MarketDepthTimeInterval);
                }
                public QuickFix.Fields.MarketDepthTimeIntervalUnit MarketDepthTimeIntervalUnit
                {
                    get
                    {
                        QuickFix.Fields.MarketDepthTimeIntervalUnit val = new QuickFix.Fields.MarketDepthTimeIntervalUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MarketDepthTimeIntervalUnit val)
                {
                    this.MarketDepthTimeIntervalUnit = val;
                }

                public QuickFix.Fields.MarketDepthTimeIntervalUnit Get(QuickFix.Fields.MarketDepthTimeIntervalUnit val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MarketDepthTimeIntervalUnit val)
                {
                    return IsSetMarketDepthTimeIntervalUnit();
                }

                public bool IsSetMarketDepthTimeIntervalUnit()
                {
                    return IsSetField(Tags.MarketDepthTimeIntervalUnit);
                }
                public QuickFix.Fields.MDRecoveryTimeInterval MDRecoveryTimeInterval
                {
                    get
                    {
                        QuickFix.Fields.MDRecoveryTimeInterval val = new QuickFix.Fields.MDRecoveryTimeInterval();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDRecoveryTimeInterval val)
                {
                    this.MDRecoveryTimeInterval = val;
                }

                public QuickFix.Fields.MDRecoveryTimeInterval Get(QuickFix.Fields.MDRecoveryTimeInterval val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDRecoveryTimeInterval val)
                {
                    return IsSetMDRecoveryTimeInterval();
                }

                public bool IsSetMDRecoveryTimeInterval()
                {
                    return IsSetField(Tags.MDRecoveryTimeInterval);
                }
                public QuickFix.Fields.MDRecoveryTimeIntervalUnit MDRecoveryTimeIntervalUnit
                {
                    get
                    {
                        QuickFix.Fields.MDRecoveryTimeIntervalUnit val = new QuickFix.Fields.MDRecoveryTimeIntervalUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDRecoveryTimeIntervalUnit val)
                {
                    this.MDRecoveryTimeIntervalUnit = val;
                }

                public QuickFix.Fields.MDRecoveryTimeIntervalUnit Get(QuickFix.Fields.MDRecoveryTimeIntervalUnit val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDRecoveryTimeIntervalUnit val)
                {
                    return IsSetMDRecoveryTimeIntervalUnit();
                }

                public bool IsSetMDRecoveryTimeIntervalUnit()
                {
                    return IsSetField(Tags.MDRecoveryTimeIntervalUnit);
                }
                public QuickFix.Fields.MDSubBookType MDSubBookType
                {
                    get
                    {
                        QuickFix.Fields.MDSubBookType val = new QuickFix.Fields.MDSubBookType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDSubBookType val)
                {
                    this.MDSubBookType = val;
                }

                public QuickFix.Fields.MDSubBookType Get(QuickFix.Fields.MDSubBookType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDSubBookType val)
                {
                    return IsSetMDSubBookType();
                }

                public bool IsSetMDSubBookType()
                {
                    return IsSetField(Tags.MDSubBookType);
                }
                public QuickFix.Fields.PrimaryServiceLocationID PrimaryServiceLocationID
                {
                    get
                    {
                        QuickFix.Fields.PrimaryServiceLocationID val = new QuickFix.Fields.PrimaryServiceLocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PrimaryServiceLocationID val)
                {
                    this.PrimaryServiceLocationID = val;
                }

                public QuickFix.Fields.PrimaryServiceLocationID Get(QuickFix.Fields.PrimaryServiceLocationID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PrimaryServiceLocationID val)
                {
                    return IsSetPrimaryServiceLocationID();
                }

                public bool IsSetPrimaryServiceLocationID()
                {
                    return IsSetField(Tags.PrimaryServiceLocationID);
                }
                public QuickFix.Fields.SecondaryServiceLocationID SecondaryServiceLocationID
                {
                    get
                    {
                        QuickFix.Fields.SecondaryServiceLocationID val = new QuickFix.Fields.SecondaryServiceLocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecondaryServiceLocationID val)
                {
                    this.SecondaryServiceLocationID = val;
                }

                public QuickFix.Fields.SecondaryServiceLocationID Get(QuickFix.Fields.SecondaryServiceLocationID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecondaryServiceLocationID val)
                {
                    return IsSetSecondaryServiceLocationID();
                }

                public bool IsSetSecondaryServiceLocationID()
                {
                    return IsSetField(Tags.SecondaryServiceLocationID);
                }

            }
            public class NoMatchRulesGroup : Group
            {
                public static int[] fieldOrder = { Tags.MatchAlgorithm, Tags.MatchType, Tags.MatchRuleProductComplex, Tags.CustomerPriority, 0 };

                public NoMatchRulesGroup()
                  : base(Tags.NoMatchRules, Tags.MatchAlgorithm, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMatchRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MatchAlgorithm MatchAlgorithm
                {
                    get
                    {
                        QuickFix.Fields.MatchAlgorithm val = new QuickFix.Fields.MatchAlgorithm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchAlgorithm val)
                {
                    this.MatchAlgorithm = val;
                }

                public QuickFix.Fields.MatchAlgorithm Get(QuickFix.Fields.MatchAlgorithm val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchAlgorithm val)
                {
                    return IsSetMatchAlgorithm();
                }

                public bool IsSetMatchAlgorithm()
                {
                    return IsSetField(Tags.MatchAlgorithm);
                }
                public QuickFix.Fields.MatchType MatchType
                {
                    get
                    {
                        QuickFix.Fields.MatchType val = new QuickFix.Fields.MatchType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchType val)
                {
                    this.MatchType = val;
                }

                public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchType val)
                {
                    return IsSetMatchType();
                }

                public bool IsSetMatchType()
                {
                    return IsSetField(Tags.MatchType);
                }
                public QuickFix.Fields.MatchRuleProductComplex MatchRuleProductComplex
                {
                    get
                    {
                        QuickFix.Fields.MatchRuleProductComplex val = new QuickFix.Fields.MatchRuleProductComplex();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchRuleProductComplex val)
                {
                    this.MatchRuleProductComplex = val;
                }

                public QuickFix.Fields.MatchRuleProductComplex Get(QuickFix.Fields.MatchRuleProductComplex val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchRuleProductComplex val)
                {
                    return IsSetMatchRuleProductComplex();
                }

                public bool IsSetMatchRuleProductComplex()
                {
                    return IsSetField(Tags.MatchRuleProductComplex);
                }
                public QuickFix.Fields.CustomerPriority CustomerPriority
                {
                    get
                    {
                        QuickFix.Fields.CustomerPriority val = new QuickFix.Fields.CustomerPriority();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CustomerPriority val)
                {
                    this.CustomerPriority = val;
                }

                public QuickFix.Fields.CustomerPriority Get(QuickFix.Fields.CustomerPriority val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CustomerPriority val)
                {
                    return IsSetCustomerPriority();
                }

                public bool IsSetCustomerPriority()
                {
                    return IsSetField(Tags.CustomerPriority);
                }

            }
            public class NoFlexProductEligibilitiesGroup : Group
            {
                public static int[] fieldOrder = { Tags.FlexProductEligibilityIndicator, Tags.FlexProductEligibilityComplex, 0 };

                public NoFlexProductEligibilitiesGroup()
                  : base(Tags.NoFlexProductEligibilities, Tags.FlexProductEligibilityIndicator, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoFlexProductEligibilitiesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.FlexProductEligibilityIndicator FlexProductEligibilityIndicator
                {
                    get
                    {
                        QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val)
                {
                    this.FlexProductEligibilityIndicator = val;
                }

                public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val)
                {
                    return IsSetFlexProductEligibilityIndicator();
                }

                public bool IsSetFlexProductEligibilityIndicator()
                {
                    return IsSetField(Tags.FlexProductEligibilityIndicator);
                }
                public QuickFix.Fields.FlexProductEligibilityComplex FlexProductEligibilityComplex
                {
                    get
                    {
                        QuickFix.Fields.FlexProductEligibilityComplex val = new QuickFix.Fields.FlexProductEligibilityComplex();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.FlexProductEligibilityComplex val)
                {
                    this.FlexProductEligibilityComplex = val;
                }

                public QuickFix.Fields.FlexProductEligibilityComplex Get(QuickFix.Fields.FlexProductEligibilityComplex val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.FlexProductEligibilityComplex val)
                {
                    return IsSetFlexProductEligibilityComplex();
                }

                public bool IsSetFlexProductEligibilityComplex()
                {
                    return IsSetField(Tags.FlexProductEligibilityComplex);
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
            public class NoMiscFeesGroup : Group
            {
                public static int[] fieldOrder = { Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, Tags.MiscFeeRate, Tags.MiscFeeAmountDue, Tags.NoMiscFeeSubTypes, Tags.MiscFeeQualifier, Tags.MiscFeeDesc, 0 };

                public NoMiscFeesGroup()
                  : base(Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMiscFeesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MiscFeeAmt MiscFeeAmt
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeAmt val = new QuickFix.Fields.MiscFeeAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeAmt val)
                {
                    this.MiscFeeAmt = val;
                }

                public QuickFix.Fields.MiscFeeAmt Get(QuickFix.Fields.MiscFeeAmt val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeAmt val)
                {
                    return IsSetMiscFeeAmt();
                }

                public bool IsSetMiscFeeAmt()
                {
                    return IsSetField(Tags.MiscFeeAmt);
                }
                public QuickFix.Fields.MiscFeeCurr MiscFeeCurr
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeCurr val = new QuickFix.Fields.MiscFeeCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeCurr val)
                {
                    this.MiscFeeCurr = val;
                }

                public QuickFix.Fields.MiscFeeCurr Get(QuickFix.Fields.MiscFeeCurr val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeCurr val)
                {
                    return IsSetMiscFeeCurr();
                }

                public bool IsSetMiscFeeCurr()
                {
                    return IsSetField(Tags.MiscFeeCurr);
                }
                public QuickFix.Fields.MiscFeeType MiscFeeType
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeType val = new QuickFix.Fields.MiscFeeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeType val)
                {
                    this.MiscFeeType = val;
                }

                public QuickFix.Fields.MiscFeeType Get(QuickFix.Fields.MiscFeeType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeType val)
                {
                    return IsSetMiscFeeType();
                }

                public bool IsSetMiscFeeType()
                {
                    return IsSetField(Tags.MiscFeeType);
                }
                public QuickFix.Fields.MiscFeeBasis MiscFeeBasis
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeBasis val = new QuickFix.Fields.MiscFeeBasis();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeBasis val)
                {
                    this.MiscFeeBasis = val;
                }

                public QuickFix.Fields.MiscFeeBasis Get(QuickFix.Fields.MiscFeeBasis val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeBasis val)
                {
                    return IsSetMiscFeeBasis();
                }

                public bool IsSetMiscFeeBasis()
                {
                    return IsSetField(Tags.MiscFeeBasis);
                }
                public QuickFix.Fields.MiscFeeRate MiscFeeRate
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeRate val = new QuickFix.Fields.MiscFeeRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeRate val)
                {
                    this.MiscFeeRate = val;
                }

                public QuickFix.Fields.MiscFeeRate Get(QuickFix.Fields.MiscFeeRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeRate val)
                {
                    return IsSetMiscFeeRate();
                }

                public bool IsSetMiscFeeRate()
                {
                    return IsSetField(Tags.MiscFeeRate);
                }
                public QuickFix.Fields.MiscFeeAmountDue MiscFeeAmountDue
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeAmountDue val = new QuickFix.Fields.MiscFeeAmountDue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeAmountDue val)
                {
                    this.MiscFeeAmountDue = val;
                }

                public QuickFix.Fields.MiscFeeAmountDue Get(QuickFix.Fields.MiscFeeAmountDue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeAmountDue val)
                {
                    return IsSetMiscFeeAmountDue();
                }

                public bool IsSetMiscFeeAmountDue()
                {
                    return IsSetField(Tags.MiscFeeAmountDue);
                }
                public QuickFix.Fields.NoMiscFeeSubTypes NoMiscFeeSubTypes
                {
                    get
                    {
                        QuickFix.Fields.NoMiscFeeSubTypes val = new QuickFix.Fields.NoMiscFeeSubTypes();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoMiscFeeSubTypes val)
                {
                    this.NoMiscFeeSubTypes = val;
                }

                public QuickFix.Fields.NoMiscFeeSubTypes Get(QuickFix.Fields.NoMiscFeeSubTypes val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoMiscFeeSubTypes val)
                {
                    return IsSetNoMiscFeeSubTypes();
                }

                public bool IsSetNoMiscFeeSubTypes()
                {
                    return IsSetField(Tags.NoMiscFeeSubTypes);
                }
                public QuickFix.Fields.MiscFeeQualifier MiscFeeQualifier
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeQualifier val = new QuickFix.Fields.MiscFeeQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeQualifier val)
                {
                    this.MiscFeeQualifier = val;
                }

                public QuickFix.Fields.MiscFeeQualifier Get(QuickFix.Fields.MiscFeeQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeQualifier val)
                {
                    return IsSetMiscFeeQualifier();
                }

                public bool IsSetMiscFeeQualifier()
                {
                    return IsSetField(Tags.MiscFeeQualifier);
                }
                public QuickFix.Fields.MiscFeeDesc MiscFeeDesc
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeDesc val = new QuickFix.Fields.MiscFeeDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeDesc val)
                {
                    this.MiscFeeDesc = val;
                }

                public QuickFix.Fields.MiscFeeDesc Get(QuickFix.Fields.MiscFeeDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeDesc val)
                {
                    return IsSetMiscFeeDesc();
                }

                public bool IsSetMiscFeeDesc()
                {
                    return IsSetField(Tags.MiscFeeDesc);
                }
                public class NoMiscFeeSubTypesGroup : Group
                {
                    public static int[] fieldOrder = { Tags.MiscFeeSubType, Tags.MiscFeeSubTypeAmt, Tags.MiscFeeSubTypeDesc, Tags.EncodedMiscFeeSubTypeDescLen, Tags.EncodedMiscFeeSubTypeDesc, 0 };

                    public NoMiscFeeSubTypesGroup()
                      : base(Tags.NoMiscFeeSubTypes, Tags.MiscFeeSubType, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoMiscFeeSubTypesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.MiscFeeSubType MiscFeeSubType
                    {
                        get
                        {
                            QuickFix.Fields.MiscFeeSubType val = new QuickFix.Fields.MiscFeeSubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.MiscFeeSubType val)
                    {
                        this.MiscFeeSubType = val;
                    }

                    public QuickFix.Fields.MiscFeeSubType Get(QuickFix.Fields.MiscFeeSubType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.MiscFeeSubType val)
                    {
                        return IsSetMiscFeeSubType();
                    }

                    public bool IsSetMiscFeeSubType()
                    {
                        return IsSetField(Tags.MiscFeeSubType);
                    }
                    public QuickFix.Fields.MiscFeeSubTypeAmt MiscFeeSubTypeAmt
                    {
                        get
                        {
                            QuickFix.Fields.MiscFeeSubTypeAmt val = new QuickFix.Fields.MiscFeeSubTypeAmt();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.MiscFeeSubTypeAmt val)
                    {
                        this.MiscFeeSubTypeAmt = val;
                    }

                    public QuickFix.Fields.MiscFeeSubTypeAmt Get(QuickFix.Fields.MiscFeeSubTypeAmt val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.MiscFeeSubTypeAmt val)
                    {
                        return IsSetMiscFeeSubTypeAmt();
                    }

                    public bool IsSetMiscFeeSubTypeAmt()
                    {
                        return IsSetField(Tags.MiscFeeSubTypeAmt);
                    }
                    public QuickFix.Fields.MiscFeeSubTypeDesc MiscFeeSubTypeDesc
                    {
                        get
                        {
                            QuickFix.Fields.MiscFeeSubTypeDesc val = new QuickFix.Fields.MiscFeeSubTypeDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.MiscFeeSubTypeDesc val)
                    {
                        this.MiscFeeSubTypeDesc = val;
                    }

                    public QuickFix.Fields.MiscFeeSubTypeDesc Get(QuickFix.Fields.MiscFeeSubTypeDesc val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.MiscFeeSubTypeDesc val)
                    {
                        return IsSetMiscFeeSubTypeDesc();
                    }

                    public bool IsSetMiscFeeSubTypeDesc()
                    {
                        return IsSetField(Tags.MiscFeeSubTypeDesc);
                    }
                    public QuickFix.Fields.EncodedMiscFeeSubTypeDescLen EncodedMiscFeeSubTypeDescLen
                    {
                        get
                        {
                            QuickFix.Fields.EncodedMiscFeeSubTypeDescLen val = new QuickFix.Fields.EncodedMiscFeeSubTypeDescLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EncodedMiscFeeSubTypeDescLen val)
                    {
                        this.EncodedMiscFeeSubTypeDescLen = val;
                    }

                    public QuickFix.Fields.EncodedMiscFeeSubTypeDescLen Get(QuickFix.Fields.EncodedMiscFeeSubTypeDescLen val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EncodedMiscFeeSubTypeDescLen val)
                    {
                        return IsSetEncodedMiscFeeSubTypeDescLen();
                    }

                    public bool IsSetEncodedMiscFeeSubTypeDescLen()
                    {
                        return IsSetField(Tags.EncodedMiscFeeSubTypeDescLen);
                    }
                    public QuickFix.Fields.EncodedMiscFeeSubTypeDesc EncodedMiscFeeSubTypeDesc
                    {
                        get
                        {
                            QuickFix.Fields.EncodedMiscFeeSubTypeDesc val = new QuickFix.Fields.EncodedMiscFeeSubTypeDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.EncodedMiscFeeSubTypeDesc val)
                    {
                        this.EncodedMiscFeeSubTypeDesc = val;
                    }

                    public QuickFix.Fields.EncodedMiscFeeSubTypeDesc Get(QuickFix.Fields.EncodedMiscFeeSubTypeDesc val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.EncodedMiscFeeSubTypeDesc val)
                    {
                        return IsSetEncodedMiscFeeSubTypeDesc();
                    }

                    public bool IsSetEncodedMiscFeeSubTypeDesc()
                    {
                        return IsSetField(Tags.EncodedMiscFeeSubTypeDesc);
                    }

                }
            }
        }
    }
}
