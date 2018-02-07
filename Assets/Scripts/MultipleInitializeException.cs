using System;

public class MultipleInitailizeException : Exception
{
    private string message = "이미 초기화된 객체입니다.";

    public MultipleInitailizeException() { }
    public MultipleInitailizeException(string message)
    {
        this.message = message;
    }

    public string Message
    {
        get{ return message; }
    }
}