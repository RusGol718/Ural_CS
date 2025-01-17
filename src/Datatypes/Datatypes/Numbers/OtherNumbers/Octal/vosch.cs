#region

using Errors.SyntaxInvalidError.ErrorDatatypes;

#endregion

namespace Datatypes.Numbers.OtherNumbers.Octal;

public class vosch : VOID, Interface_UBinch, Interface_Ural_Datatype
{
    public const string Reference = "В#";
    public const string DefaultValue = Reference + "0";
    public const int MaxLength = 16;
    public const ulong MaxValue = 281474976710655U;
    public const uint MinValue = 0U;

    public vosch(string _value) : base(_value)
    {
        if ((Slice(_value, 0, 2) == Reference) & (VoschCheck(_value).value == "ИСТИНА")) { this.value = _value; }
        else if ((Slice(_value, 0, 2) != Reference) &
                 (VoschCheck(Reference + _value).value == "ИСТИНА")) { this.value = Reference + _value; }
        else
        {
            SyntaxInvalidVoschDatatypeError er = new SyntaxInvalidVoschDatatypeError(0, 0);
            this.value = DefaultValue;
        }

        if (Slice(_value, 0, 2).Length > MaxLength)
            //ошибка;
        {
            this.value = DefaultValue;
        }
    }

    public vosch(ushort _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = this.NatchToVosch(_value);
    }

    public vosch(uint _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = this.NatchToVosch(_value);
    }

    public vosch(ulong _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = this.NatchToVosch(_value);
    }

    public dynamic NatchToVosch(ushort _value)
    {
        int dec = Convert.ToInt32(_value);

        string result = "";
        switch (dec)
        {
            case 0 :
                return Reference + "0";
            case 1 :
                return Reference + "1";
            default :
            {
                while (dec > 0)
                {
                    result = Convert.ToString(dec % 8) + result;
                    dec = dec / 8;
                }

                return Reference + result;
            }
        }
    }

    public dynamic NatchToVosch(uint _value)
    {
        int dec = Convert.ToInt32(_value);

        string result = "";
        switch (dec)
        {
            case 0 :
                return Reference + "0";
            case 1 :
                return Reference + "1";
            default :
            {
                while (dec > 0)
                {
                    result = Convert.ToString(dec % 8) + result;
                    dec = dec / 8;
                }

                return Reference + result;
            }
        }
    }

    public dynamic NatchToVosch(ulong _value)
    {
        ulong dec = Convert.ToUInt64(_value);

        string result = "";
        switch (dec)
        {
            case 0 :
                return Reference + "0";
            case 1 :
                return Reference + "1";
            default :
            {
                while (dec > 0)
                {
                    result = Convert.ToString(dec % 8) + result;
                    dec = dec / 8;
                }

                return Reference + result;
            }
        }
    }

    protected static RCI VoschCheck(string bin)
    {
        RCI flag = new RCI(true);
        if (Slice(bin, 0, 2) == binch.Reference)
        {
            for (int i = 2; i < bin.Length; i++)
                switch ((bin[i] == '0') | (bin[i] == '1') | (bin[i] == '2') | (bin[i] == '3') | (bin[i] == '4') |
                        (bin[i] == '5') | (bin[i] == '6') | (bin[i] == '7'))
                {
                    case true :
                        flag = RCI.I(flag, flag);
                        break;
                    default :
                        flag = new RCI(false);
                        flag = RCI.I(flag, flag);
                        break;
                }

            return flag;
        }

        flag = new RCI(false);
        return flag;
    }
}