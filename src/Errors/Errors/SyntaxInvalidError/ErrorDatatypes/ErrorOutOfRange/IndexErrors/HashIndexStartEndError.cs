namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange.IndexErrors;

public class HashIndexStartEndError : Error
{
    public HashIndexStartEndError(int _position_start, int _position_end,
        string _error_name = "Длина, хеша не в диапазоне или ключа не существует: ",
        string _discription = "проверьте ваш хеш и убедитесь что ключи и значения не пересекаеться между собой или что такой ключ  существует.") :
        base(_position_start,
            _position_end, _error_name, _discription)
    {
    }
}