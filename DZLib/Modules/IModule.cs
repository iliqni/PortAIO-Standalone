using System;

using EloBuddy; 
using LeagueSharp.Common; 
 namespace DZLib.Modules
{
    public interface IModule
    {
        void OnLoad();

        string GetName();

        bool ShouldGetExecuted();

        ModuleType GetModuleType();

        void OnExecute();
    }
}
