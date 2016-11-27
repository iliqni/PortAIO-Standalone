
#pragma warning disable 1587

using EloBuddy; 
using LeagueSharp.SDK; 
 namespace ExorAIO
{
    using EloBuddy.SDK.Events;
    using LeagueSharp.SDK;

    internal class Program
    {
        #region Methods

        /// <summary>
        ///     The entry point of the application.
        /// </summary>
        private static void Main()
        {
            /// <summary>
            ///     Loads the Bootstrap.
            /// </summary>
            Bootstrap.Init();
            Loading.OnLoadingComplete += (eventArgs) =>
                {
                    /// <summary>
                    ///     Loads the AIO.
                    /// </summary>
                    Aio.OnLoad();
                };
        }

        #endregion
    }
}