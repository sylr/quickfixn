// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class UserNotification : Message
        {
            public const string MsgType = "CB";

            public UserNotification() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CB"));
            }

            public UserNotification(
                    QuickFix.Fields.UserStatus aUserStatus
                ) : this()
            {
                this.UserStatus = aUserStatus;
            }

            public QuickFix.Fields.NoUsernames NoUsernames
            {
                get
                {
                    QuickFix.Fields.NoUsernames val = new QuickFix.Fields.NoUsernames();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoUsernames val)
            {
                this.NoUsernames = val;
            }

            public QuickFix.Fields.NoUsernames Get(QuickFix.Fields.NoUsernames val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoUsernames val)
            {
                return IsSetNoUsernames();
            }

            public bool IsSetNoUsernames()
            {
                return IsSetField(Tags.NoUsernames);
            }
            public QuickFix.Fields.UserStatus UserStatus
            {
                get
                {
                    QuickFix.Fields.UserStatus val = new QuickFix.Fields.UserStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UserStatus val)
            {
                this.UserStatus = val;
            }

            public QuickFix.Fields.UserStatus Get(QuickFix.Fields.UserStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UserStatus val)
            {
                return IsSetUserStatus();
            }

            public bool IsSetUserStatus()
            {
                return IsSetField(Tags.UserStatus);
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
            public QuickFix.Fields.NoThrottles NoThrottles
            {
                get
                {
                    QuickFix.Fields.NoThrottles val = new QuickFix.Fields.NoThrottles();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoThrottles val)
            {
                this.NoThrottles = val;
            }

            public QuickFix.Fields.NoThrottles Get(QuickFix.Fields.NoThrottles val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoThrottles val)
            {
                return IsSetNoThrottles();
            }

            public bool IsSetNoThrottles()
            {
                return IsSetField(Tags.NoThrottles);
            }
            public class NoUsernamesGroup : Group
            {
                public static int[] fieldOrder = { Tags.Username, 0 };

                public NoUsernamesGroup()
                  : base(Tags.NoUsernames, Tags.Username, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoUsernamesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.Username Username
                {
                    get
                    {
                        QuickFix.Fields.Username val = new QuickFix.Fields.Username();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Username val)
                {
                    this.Username = val;
                }

                public QuickFix.Fields.Username Get(QuickFix.Fields.Username val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Username val)
                {
                    return IsSetUsername();
                }

                public bool IsSetUsername()
                {
                    return IsSetField(Tags.Username);
                }

            }
            public class NoThrottlesGroup : Group
            {
                public static int[] fieldOrder = { Tags.ThrottleAction, Tags.ThrottleType, Tags.ThrottleNoMsgs, Tags.ThrottleTimeInterval, Tags.ThrottleTimeUnit, Tags.NoThrottleMsgType, 0 };

                public NoThrottlesGroup()
                  : base(Tags.NoThrottles, Tags.ThrottleAction, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoThrottlesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.ThrottleAction ThrottleAction
                {
                    get
                    {
                        QuickFix.Fields.ThrottleAction val = new QuickFix.Fields.ThrottleAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ThrottleAction val)
                {
                    this.ThrottleAction = val;
                }

                public QuickFix.Fields.ThrottleAction Get(QuickFix.Fields.ThrottleAction val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ThrottleAction val)
                {
                    return IsSetThrottleAction();
                }

                public bool IsSetThrottleAction()
                {
                    return IsSetField(Tags.ThrottleAction);
                }
                public QuickFix.Fields.ThrottleType ThrottleType
                {
                    get
                    {
                        QuickFix.Fields.ThrottleType val = new QuickFix.Fields.ThrottleType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ThrottleType val)
                {
                    this.ThrottleType = val;
                }

                public QuickFix.Fields.ThrottleType Get(QuickFix.Fields.ThrottleType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ThrottleType val)
                {
                    return IsSetThrottleType();
                }

                public bool IsSetThrottleType()
                {
                    return IsSetField(Tags.ThrottleType);
                }
                public QuickFix.Fields.ThrottleNoMsgs ThrottleNoMsgs
                {
                    get
                    {
                        QuickFix.Fields.ThrottleNoMsgs val = new QuickFix.Fields.ThrottleNoMsgs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ThrottleNoMsgs val)
                {
                    this.ThrottleNoMsgs = val;
                }

                public QuickFix.Fields.ThrottleNoMsgs Get(QuickFix.Fields.ThrottleNoMsgs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ThrottleNoMsgs val)
                {
                    return IsSetThrottleNoMsgs();
                }

                public bool IsSetThrottleNoMsgs()
                {
                    return IsSetField(Tags.ThrottleNoMsgs);
                }
                public QuickFix.Fields.ThrottleTimeInterval ThrottleTimeInterval
                {
                    get
                    {
                        QuickFix.Fields.ThrottleTimeInterval val = new QuickFix.Fields.ThrottleTimeInterval();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ThrottleTimeInterval val)
                {
                    this.ThrottleTimeInterval = val;
                }

                public QuickFix.Fields.ThrottleTimeInterval Get(QuickFix.Fields.ThrottleTimeInterval val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ThrottleTimeInterval val)
                {
                    return IsSetThrottleTimeInterval();
                }

                public bool IsSetThrottleTimeInterval()
                {
                    return IsSetField(Tags.ThrottleTimeInterval);
                }
                public QuickFix.Fields.ThrottleTimeUnit ThrottleTimeUnit
                {
                    get
                    {
                        QuickFix.Fields.ThrottleTimeUnit val = new QuickFix.Fields.ThrottleTimeUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ThrottleTimeUnit val)
                {
                    this.ThrottleTimeUnit = val;
                }

                public QuickFix.Fields.ThrottleTimeUnit Get(QuickFix.Fields.ThrottleTimeUnit val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ThrottleTimeUnit val)
                {
                    return IsSetThrottleTimeUnit();
                }

                public bool IsSetThrottleTimeUnit()
                {
                    return IsSetField(Tags.ThrottleTimeUnit);
                }
                public QuickFix.Fields.NoThrottleMsgType NoThrottleMsgType
                {
                    get
                    {
                        QuickFix.Fields.NoThrottleMsgType val = new QuickFix.Fields.NoThrottleMsgType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoThrottleMsgType val)
                {
                    this.NoThrottleMsgType = val;
                }

                public QuickFix.Fields.NoThrottleMsgType Get(QuickFix.Fields.NoThrottleMsgType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoThrottleMsgType val)
                {
                    return IsSetNoThrottleMsgType();
                }

                public bool IsSetNoThrottleMsgType()
                {
                    return IsSetField(Tags.NoThrottleMsgType);
                }
                public class NoThrottleMsgTypeGroup : Group
                {
                    public static int[] fieldOrder = { Tags.ThrottleMsgType, 0 };

                    public NoThrottleMsgTypeGroup()
                      : base(Tags.NoThrottleMsgType, Tags.ThrottleMsgType, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoThrottleMsgTypeGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.ThrottleMsgType ThrottleMsgType
                    {
                        get
                        {
                            QuickFix.Fields.ThrottleMsgType val = new QuickFix.Fields.ThrottleMsgType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.ThrottleMsgType val)
                    {
                        this.ThrottleMsgType = val;
                    }

                    public QuickFix.Fields.ThrottleMsgType Get(QuickFix.Fields.ThrottleMsgType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.ThrottleMsgType val)
                    {
                        return IsSetThrottleMsgType();
                    }

                    public bool IsSetThrottleMsgType()
                    {
                        return IsSetField(Tags.ThrottleMsgType);
                    }

                }
            }
        }
    }
}
