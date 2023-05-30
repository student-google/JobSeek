﻿using NuGet.Protocol;

namespace JobSeek.Api.Responses

{
    public class SingleResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public string  Message { get; set; }
        public T? Result { get; set; }

        public static SingleResponse<T> Success(T result)
        {
            return new SingleResponse<T> { Status = ResponseStatus.Success, Result = result };
        }
        public static SingleResponse<T> Failed(ResponseStatus status)
        {
            return new SingleResponse<T> { Status = status, Result = default };
        }

        public static implicit operator SingleResponse<T>(ResponseStatus status)
        {
            return SingleResponse<T>.Failed(status);
        }

        public static implicit operator SingleResponse<T>(T result)
        {
            return SingleResponse<T>.Success(result);
        }
        public static implicit operator SingleResponse<T>(Tuple<ResponseStatus, string> v)
        {
            return new SingleResponse<T> { Status = v.Item1, Message = v.Item2 };
        }
    }
}
