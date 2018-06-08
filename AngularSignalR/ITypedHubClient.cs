using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularSignalR
{
    public interface ITypedHubClient
    {
        Task BroadCastMessage(string type,string payload);
    }
}
