namespace banxft.Assembly
{
    using System;
    using System.Reflection;
    using System.Security.Permissions;
    using EnsoulSharp.SDK;
    using banxftScripts.Properties;
    class Program
    {
        static void Main(string[] args)
        {
            GameEvent.OnGameLoad += new GameEvent.OnGameLoadDelegate(Program.OnGameLoad);
        }
        [PermissionSet(SecurityAction.Assert, Unrestricted = true)]
        private static void OnGameLoad()
        {
            var a = Assembly.Load(Resources.banxftScript);
            var myType = a.GetType("banxft.Program");
            var methon = myType.GetMethod("Main", BindingFlags.Public | BindingFlags.Static);

            if (methon != null)
            {
                methon.Invoke(null, null);
            }
        }
    }
}