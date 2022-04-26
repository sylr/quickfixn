// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class ConfirmationAck : Message
        {
            public const string MsgType = "AU";

            public ConfirmationAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AU"));
            }

            public ConfirmationAck(
                    QuickFix.Fields.ConfirmID aConfirmID,
                    QuickFix.Fields.TradeDate aTradeDate,
                    QuickFix.Fields.TransactTime aTransactTime,
                    QuickFix.Fields.AffirmStatus aAffirmStatus
                ) : this()
            {
                this.ConfirmID = aConfirmID;
                this.TradeDate = aTradeDate;
                this.TransactTime = aTransactTime;
                this.AffirmStatus = aAffirmStatus;
            }

            public QuickFix.Fields.ConfirmID ConfirmID
            {
                get
                {
                    QuickFix.Fields.ConfirmID val = new QuickFix.Fields.ConfirmID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ConfirmID val)
            {
                this.ConfirmID = val;
            }

            public QuickFix.Fields.ConfirmID Get(QuickFix.Fields.ConfirmID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ConfirmID val)
            {
                return IsSetConfirmID();
            }

            public bool IsSetConfirmID()
            {
                return IsSetField(Tags.ConfirmID);
            }
            public QuickFix.Fields.TradeDate TradeDate
            {
                get
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradeDate val)
            {
                this.TradeDate = val;
            }

            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradeDate val)
            {
                return IsSetTradeDate();
            }

            public bool IsSetTradeDate()
            {
                return IsSetField(Tags.TradeDate);
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
            public QuickFix.Fields.AffirmStatus AffirmStatus
            {
                get
                {
                    QuickFix.Fields.AffirmStatus val = new QuickFix.Fields.AffirmStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AffirmStatus val)
            {
                this.AffirmStatus = val;
            }

            public QuickFix.Fields.AffirmStatus Get(QuickFix.Fields.AffirmStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AffirmStatus val)
            {
                return IsSetAffirmStatus();
            }

            public bool IsSetAffirmStatus()
            {
                return IsSetField(Tags.AffirmStatus);
            }
            public QuickFix.Fields.ConfirmRejReason ConfirmRejReason
            {
                get
                {
                    QuickFix.Fields.ConfirmRejReason val = new QuickFix.Fields.ConfirmRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ConfirmRejReason val)
            {
                this.ConfirmRejReason = val;
            }

            public QuickFix.Fields.ConfirmRejReason Get(QuickFix.Fields.ConfirmRejReason val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ConfirmRejReason val)
            {
                return IsSetConfirmRejReason();
            }

            public bool IsSetConfirmRejReason()
            {
                return IsSetField(Tags.ConfirmRejReason);
            }
            public QuickFix.Fields.MatchStatus MatchStatus
            {
                get
                {
                    QuickFix.Fields.MatchStatus val = new QuickFix.Fields.MatchStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MatchStatus val)
            {
                this.MatchStatus = val;
            }

            public QuickFix.Fields.MatchStatus Get(QuickFix.Fields.MatchStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MatchStatus val)
            {
                return IsSetMatchStatus();
            }

            public bool IsSetMatchStatus()
            {
                return IsSetField(Tags.MatchStatus);
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
            public QuickFix.Fields.TradeConfirmationReferenceID TradeConfirmationReferenceID
            {
                get
                {
                    QuickFix.Fields.TradeConfirmationReferenceID val = new QuickFix.Fields.TradeConfirmationReferenceID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradeConfirmationReferenceID val)
            {
                this.TradeConfirmationReferenceID = val;
            }

            public QuickFix.Fields.TradeConfirmationReferenceID Get(QuickFix.Fields.TradeConfirmationReferenceID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradeConfirmationReferenceID val)
            {
                return IsSetTradeConfirmationReferenceID();
            }

            public bool IsSetTradeConfirmationReferenceID()
            {
                return IsSetField(Tags.TradeConfirmationReferenceID);
            }
            public QuickFix.Fields.NoMatchExceptions NoMatchExceptions
            {
                get
                {
                    QuickFix.Fields.NoMatchExceptions val = new QuickFix.Fields.NoMatchExceptions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMatchExceptions val)
            {
                this.NoMatchExceptions = val;
            }

            public QuickFix.Fields.NoMatchExceptions Get(QuickFix.Fields.NoMatchExceptions val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMatchExceptions val)
            {
                return IsSetNoMatchExceptions();
            }

            public bool IsSetNoMatchExceptions()
            {
                return IsSetField(Tags.NoMatchExceptions);
            }
            public QuickFix.Fields.NoMatchingDataPoints NoMatchingDataPoints
            {
                get
                {
                    QuickFix.Fields.NoMatchingDataPoints val = new QuickFix.Fields.NoMatchingDataPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMatchingDataPoints val)
            {
                this.NoMatchingDataPoints = val;
            }

            public QuickFix.Fields.NoMatchingDataPoints Get(QuickFix.Fields.NoMatchingDataPoints val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMatchingDataPoints val)
            {
                return IsSetNoMatchingDataPoints();
            }

            public bool IsSetNoMatchingDataPoints()
            {
                return IsSetField(Tags.NoMatchingDataPoints);
            }
            public class NoMatchExceptionsGroup : Group
            {
                public static int[] fieldOrder = { Tags.MatchExceptionType, Tags.MatchExceptionElementType, Tags.MatchExceptionElementName, Tags.MatchExceptionAllocValue, Tags.MatchExceptionConfirmValue, Tags.MatchExceptionToleranceValue, Tags.MatchExceptionToleranceValueType, Tags.MatchExceptionText, Tags.EncodedMatchExceptionTextLen, Tags.EncodedMatchExecptionText, 0 };

                public NoMatchExceptionsGroup()
                  : base(Tags.NoMatchExceptions, Tags.MatchExceptionType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMatchExceptionsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MatchExceptionType MatchExceptionType
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionType val = new QuickFix.Fields.MatchExceptionType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionType val)
                {
                    this.MatchExceptionType = val;
                }

                public QuickFix.Fields.MatchExceptionType Get(QuickFix.Fields.MatchExceptionType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionType val)
                {
                    return IsSetMatchExceptionType();
                }

                public bool IsSetMatchExceptionType()
                {
                    return IsSetField(Tags.MatchExceptionType);
                }
                public QuickFix.Fields.MatchExceptionElementType MatchExceptionElementType
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionElementType val = new QuickFix.Fields.MatchExceptionElementType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionElementType val)
                {
                    this.MatchExceptionElementType = val;
                }

                public QuickFix.Fields.MatchExceptionElementType Get(QuickFix.Fields.MatchExceptionElementType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionElementType val)
                {
                    return IsSetMatchExceptionElementType();
                }

                public bool IsSetMatchExceptionElementType()
                {
                    return IsSetField(Tags.MatchExceptionElementType);
                }
                public QuickFix.Fields.MatchExceptionElementName MatchExceptionElementName
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionElementName val = new QuickFix.Fields.MatchExceptionElementName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionElementName val)
                {
                    this.MatchExceptionElementName = val;
                }

                public QuickFix.Fields.MatchExceptionElementName Get(QuickFix.Fields.MatchExceptionElementName val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionElementName val)
                {
                    return IsSetMatchExceptionElementName();
                }

                public bool IsSetMatchExceptionElementName()
                {
                    return IsSetField(Tags.MatchExceptionElementName);
                }
                public QuickFix.Fields.MatchExceptionAllocValue MatchExceptionAllocValue
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionAllocValue val = new QuickFix.Fields.MatchExceptionAllocValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionAllocValue val)
                {
                    this.MatchExceptionAllocValue = val;
                }

                public QuickFix.Fields.MatchExceptionAllocValue Get(QuickFix.Fields.MatchExceptionAllocValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionAllocValue val)
                {
                    return IsSetMatchExceptionAllocValue();
                }

                public bool IsSetMatchExceptionAllocValue()
                {
                    return IsSetField(Tags.MatchExceptionAllocValue);
                }
                public QuickFix.Fields.MatchExceptionConfirmValue MatchExceptionConfirmValue
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionConfirmValue val = new QuickFix.Fields.MatchExceptionConfirmValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionConfirmValue val)
                {
                    this.MatchExceptionConfirmValue = val;
                }

                public QuickFix.Fields.MatchExceptionConfirmValue Get(QuickFix.Fields.MatchExceptionConfirmValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionConfirmValue val)
                {
                    return IsSetMatchExceptionConfirmValue();
                }

                public bool IsSetMatchExceptionConfirmValue()
                {
                    return IsSetField(Tags.MatchExceptionConfirmValue);
                }
                public QuickFix.Fields.MatchExceptionToleranceValue MatchExceptionToleranceValue
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionToleranceValue val = new QuickFix.Fields.MatchExceptionToleranceValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionToleranceValue val)
                {
                    this.MatchExceptionToleranceValue = val;
                }

                public QuickFix.Fields.MatchExceptionToleranceValue Get(QuickFix.Fields.MatchExceptionToleranceValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionToleranceValue val)
                {
                    return IsSetMatchExceptionToleranceValue();
                }

                public bool IsSetMatchExceptionToleranceValue()
                {
                    return IsSetField(Tags.MatchExceptionToleranceValue);
                }
                public QuickFix.Fields.MatchExceptionToleranceValueType MatchExceptionToleranceValueType
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionToleranceValueType val = new QuickFix.Fields.MatchExceptionToleranceValueType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionToleranceValueType val)
                {
                    this.MatchExceptionToleranceValueType = val;
                }

                public QuickFix.Fields.MatchExceptionToleranceValueType Get(QuickFix.Fields.MatchExceptionToleranceValueType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionToleranceValueType val)
                {
                    return IsSetMatchExceptionToleranceValueType();
                }

                public bool IsSetMatchExceptionToleranceValueType()
                {
                    return IsSetField(Tags.MatchExceptionToleranceValueType);
                }
                public QuickFix.Fields.MatchExceptionText MatchExceptionText
                {
                    get
                    {
                        QuickFix.Fields.MatchExceptionText val = new QuickFix.Fields.MatchExceptionText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchExceptionText val)
                {
                    this.MatchExceptionText = val;
                }

                public QuickFix.Fields.MatchExceptionText Get(QuickFix.Fields.MatchExceptionText val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchExceptionText val)
                {
                    return IsSetMatchExceptionText();
                }

                public bool IsSetMatchExceptionText()
                {
                    return IsSetField(Tags.MatchExceptionText);
                }
                public QuickFix.Fields.EncodedMatchExceptionTextLen EncodedMatchExceptionTextLen
                {
                    get
                    {
                        QuickFix.Fields.EncodedMatchExceptionTextLen val = new QuickFix.Fields.EncodedMatchExceptionTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedMatchExceptionTextLen val)
                {
                    this.EncodedMatchExceptionTextLen = val;
                }

                public QuickFix.Fields.EncodedMatchExceptionTextLen Get(QuickFix.Fields.EncodedMatchExceptionTextLen val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedMatchExceptionTextLen val)
                {
                    return IsSetEncodedMatchExceptionTextLen();
                }

                public bool IsSetEncodedMatchExceptionTextLen()
                {
                    return IsSetField(Tags.EncodedMatchExceptionTextLen);
                }
                public QuickFix.Fields.EncodedMatchExecptionText EncodedMatchExecptionText
                {
                    get
                    {
                        QuickFix.Fields.EncodedMatchExecptionText val = new QuickFix.Fields.EncodedMatchExecptionText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedMatchExecptionText val)
                {
                    this.EncodedMatchExecptionText = val;
                }

                public QuickFix.Fields.EncodedMatchExecptionText Get(QuickFix.Fields.EncodedMatchExecptionText val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedMatchExecptionText val)
                {
                    return IsSetEncodedMatchExecptionText();
                }

                public bool IsSetEncodedMatchExecptionText()
                {
                    return IsSetField(Tags.EncodedMatchExecptionText);
                }

            }
            public class NoMatchingDataPointsGroup : Group
            {
                public static int[] fieldOrder = { Tags.MatchingDataPointIndicator, Tags.MatchingDataPointValue, Tags.MatchingDataPointType, Tags.MatchingDataPointName, 0 };

                public NoMatchingDataPointsGroup()
                  : base(Tags.NoMatchingDataPoints, Tags.MatchingDataPointIndicator, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMatchingDataPointsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MatchingDataPointIndicator MatchingDataPointIndicator
                {
                    get
                    {
                        QuickFix.Fields.MatchingDataPointIndicator val = new QuickFix.Fields.MatchingDataPointIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchingDataPointIndicator val)
                {
                    this.MatchingDataPointIndicator = val;
                }

                public QuickFix.Fields.MatchingDataPointIndicator Get(QuickFix.Fields.MatchingDataPointIndicator val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchingDataPointIndicator val)
                {
                    return IsSetMatchingDataPointIndicator();
                }

                public bool IsSetMatchingDataPointIndicator()
                {
                    return IsSetField(Tags.MatchingDataPointIndicator);
                }
                public QuickFix.Fields.MatchingDataPointValue MatchingDataPointValue
                {
                    get
                    {
                        QuickFix.Fields.MatchingDataPointValue val = new QuickFix.Fields.MatchingDataPointValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchingDataPointValue val)
                {
                    this.MatchingDataPointValue = val;
                }

                public QuickFix.Fields.MatchingDataPointValue Get(QuickFix.Fields.MatchingDataPointValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchingDataPointValue val)
                {
                    return IsSetMatchingDataPointValue();
                }

                public bool IsSetMatchingDataPointValue()
                {
                    return IsSetField(Tags.MatchingDataPointValue);
                }
                public QuickFix.Fields.MatchingDataPointType MatchingDataPointType
                {
                    get
                    {
                        QuickFix.Fields.MatchingDataPointType val = new QuickFix.Fields.MatchingDataPointType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchingDataPointType val)
                {
                    this.MatchingDataPointType = val;
                }

                public QuickFix.Fields.MatchingDataPointType Get(QuickFix.Fields.MatchingDataPointType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchingDataPointType val)
                {
                    return IsSetMatchingDataPointType();
                }

                public bool IsSetMatchingDataPointType()
                {
                    return IsSetField(Tags.MatchingDataPointType);
                }
                public QuickFix.Fields.MatchingDataPointName MatchingDataPointName
                {
                    get
                    {
                        QuickFix.Fields.MatchingDataPointName val = new QuickFix.Fields.MatchingDataPointName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MatchingDataPointName val)
                {
                    this.MatchingDataPointName = val;
                }

                public QuickFix.Fields.MatchingDataPointName Get(QuickFix.Fields.MatchingDataPointName val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MatchingDataPointName val)
                {
                    return IsSetMatchingDataPointName();
                }

                public bool IsSetMatchingDataPointName()
                {
                    return IsSetField(Tags.MatchingDataPointName);
                }

            }
        }
    }
}
