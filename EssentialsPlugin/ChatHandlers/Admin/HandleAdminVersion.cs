﻿namespace EssentialsPlugin.ChatHandlers.Admin
{
    using System;
    using EssentialsPlugin;
    using EssentialsPlugin.Utility;
    using System.IO;
    using System.Linq;
    using NLog;
    using Sandbox.Common;
    using Sandbox.Common.ObjectBuilders;
    using Sandbox.ModAPI;
    using SEModAPIExtensions.API;
    using SEModAPIInternal.API.Common;
    using SEModAPIInternal.API.Entity;
    using SEModAPIInternal.API.Entity.Sector.SectorObject;
    using SEModAPIInternal.API.Server;
    using VRage;
    using VRageMath;
    using VRage.ModAPI;
    using VRage.Serialization;
    using Sandbox.Common.ObjectBuilders.ComponentSystem;

    public class HandleAdminVersion : ChatHandlerBase
    {
        public override string GetHelp( )
        {
            return "Returns version number of Essentials plugin. Usage: /admin version";
        }

        public override string GetCommandText( )
        {
            return "/admin version";
        }

        public override string GetHelpDialog()
        {
            string longMessage =
                "/dialog \"Help\" \"\" \"\"" +
                "\"Sorry, there's nothing here yet :(\" \"close\" ";
            return longMessage;
        }

        public override bool IsAdminCommand( )
        {
            return true;
        }

        public override bool AllowedInConsole( )
        {
            return true;
        }

        public override bool HandleCommand( ulong userId, string[] words )
        {
            //Log.Info( "Plugin '{0}' initialized. (Version: {1}  ID: {2})", Name, Version, Id );
            //Version version = typeof( Essentials ).Assembly.GetName( ).Version;
            //Communication.SendPrivateInformation( userId, (String)version );
            
            Communication.SendPrivateInformation( userId, String.Format("Plugin '{0}' initialized. (Version: {1}  ID: {2})", 
                                                     Essentials.Instance.Name, Essentials.Instance.Version, Essentials.Instance.Id) );

            return true;
        }

    }

}

