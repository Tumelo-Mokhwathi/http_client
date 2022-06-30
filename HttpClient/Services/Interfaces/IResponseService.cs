using HttpClient.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClient.Services.Interfaces
{
    public interface IResponseService
    {
        public Models.Response GetResponseAsync();
    }
}
