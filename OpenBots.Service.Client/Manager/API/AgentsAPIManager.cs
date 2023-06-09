﻿using OpenBots.Agent.Core.Model;
using OpenBots.Service.API.Api;
using OpenBots.Service.API.Client;
using OpenBots.Service.API.Model;
using System;

namespace OpenBots.Service.Client.Manager.API
{
    public static class AgentsAPIManager
    {
        public static ApiResponse<NextJobViewModel> SendAgentHeartBeat(AuthAPIManager apiManager, string agentId, HeartbeatViewModel body)
        {
            AgentsApi agentsApi = new AgentsApi(apiManager.Configuration);

            try
            {
                return agentsApi.ApiV1AgentsAgentIdAddHeartbeatPostWithHttpInfo(agentId, body);
            }
            catch (Exception ex)
            {
                // In case of Unauthorized request
                if (ex.GetType().GetProperty("ErrorCode").GetValue(ex, null).ToString() == "401")
                {
                    // Refresh Token and Call API
                    agentsApi.Configuration.AccessToken = apiManager.GetToken();
                    return agentsApi.ApiV1AgentsAgentIdAddHeartbeatPostWithHttpInfo(agentId, body);
                }
                throw ex;
            }
        }

        public static ApiResponse<ConnectedViewModel> ConnectAgent(AuthAPIManager apiManager, ServerConnectionSettings serverSettings)
        {
            AgentsApi agentsApi = new AgentsApi(apiManager.Configuration);

            try
            {
                return agentsApi.ApiV1AgentsConnectPatchWithHttpInfo(serverSettings.AgentId, serverSettings.MachineName, serverSettings.MACAddress);
            }
            catch (Exception ex)
            {
                // In case of Unauthorized request
                if (ex.GetType().GetProperty("ErrorCode").GetValue(ex, null).ToString() == "401")
                {
                    // Refresh Token and Call API
                    agentsApi.Configuration.AccessToken = apiManager.GetToken();
                    return agentsApi.ApiV1AgentsConnectPatchWithHttpInfo(serverSettings.AgentId, serverSettings.MachineName, serverSettings.MACAddress);
                }
                throw ex;
            }
        }

        public static ApiResponse<IActionResult> DisconnectAgent(AuthAPIManager apiManager, ServerConnectionSettings serverSettings)
        {
            AgentsApi agentsApi = new AgentsApi(apiManager.Configuration);
            try
            {
                return agentsApi.ApiV1AgentsDisconnectPatchWithHttpInfo(serverSettings.AgentId, serverSettings.MachineName, serverSettings.MACAddress);
            }
            catch (Exception ex)
            {
                // In case of Unauthorized request
                if (ex.GetType().GetProperty("ErrorCode").GetValue(ex, null).ToString() == "401")
                {
                    // Refresh Token and Call API
                    agentsApi.Configuration.AccessToken = apiManager.GetToken();
                    return agentsApi.ApiV1AgentsDisconnectPatchWithHttpInfo(serverSettings.AgentId, serverSettings.MachineName, serverSettings.MACAddress);
                }
                throw ex;
            }
        }

        public static string CreateAgent(AuthAPIManager apiManager, ServerConnectionSettings serverSettings)
        {
            AgentsApi agentsApi = new AgentsApi(apiManager.Configuration);
            var agentModel = new CreateAgentViewModel(null, serverSettings.AgentName, serverSettings.DNSHost, serverSettings.MACAddress,
                serverSettings.IPAddress, true, null, null, null, null, true, false, null, 
                serverSettings.AgentUsername, serverSettings.AgentPassword);
            
            try
            {
                return agentsApi.ApiV1AgentsPostWithHttpInfo(agentModel).Data.Id.ToString();
            }
            catch (Exception ex)
            {
                // In case of Unauthorized request
                if (ex.GetType().GetProperty("ErrorCode").GetValue(ex, null).ToString() == "401")
                {
                    // Refresh Token and Call API
                    agentsApi.Configuration.AccessToken = apiManager.GetToken();
                    return agentsApi.ApiV1AgentsPostWithHttpInfo(agentModel).Data.Id.ToString();
                }
                throw ex;
            }
        }

        public static bool FindAgent(AuthAPIManager apiManager, string filter)
        {
            AgentsApi agentsApi = new AgentsApi(apiManager.Configuration);

            try
            {
                return (agentsApi.ApiV1AgentsGetWithHttpInfo(filter).Data.Items.Count == 0) ? false : true;
            }
            catch (Exception ex)
            {
                // In case of Unauthorized request
                if (ex.GetType().GetProperty("ErrorCode").GetValue(ex, null).ToString() == "401")
                {
                    // Refresh Token and Call API
                    agentsApi.Configuration.AccessToken = apiManager.GetToken();
                    return (agentsApi.ApiV1AgentsGetWithHttpInfo(filter).Data.Items.Count == 0) ? false : true;
                }
                throw ex;
            }
        }

        public static AgentViewModel GetAgent(AuthAPIManager apiManager, string agentId)
        {
            AgentsApi agentsApi = new AgentsApi(apiManager.Configuration);

            try
            {
                return agentsApi.GetAgentModel(agentId);
            }
            catch (Exception ex)
            {
                // In case of Unauthorized request
                if (ex.GetType().GetProperty("ErrorCode").GetValue(ex, null).ToString() == "401")
                {
                    // Refresh Token and Call API
                    agentsApi.Configuration.AccessToken = apiManager.GetToken();
                    return agentsApi.GetAgentModel(agentId);
                }
                throw ex;
            }
        }
    }
}
