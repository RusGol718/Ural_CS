namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class Drobch16OutOfRangeMaxError : SyntaxInvalidDrobchDatatypeError
{
    public Drobch16OutOfRangeMaxError(int _position_start, int _position_end,
        string _error_name = "Дробное число не в диапазоне:",
        string _discription = "число не должно превышать 65535.0 .") : base(_position_start, _position_end,
        _error_name, _discription)
    {
        // Inherited Constructor
    }
}