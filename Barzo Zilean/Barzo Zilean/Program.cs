namespace Barzo_Zilean
{
    using System;
    using System.Reflection;
    using System.Security.Permissions;
    using EnsoulSharp.SDK;
    using Barzo_Zilean.Properties;
    class Program
    {
        static void Main(string[] args)
        {
            GameEvent.OnGameLoad += OnGameLoad;
        }
        [PermissionSet(SecurityAction.Assert, Unrestricted = true)]
        private static void OnGameLoad()
        {
            var a = Assembly.Load(Resources.Zilean);
            var myType = a.GetType("Zilean.Program");
            var methon = myType.GetMethod("Main", BindingFlags.Public | BindingFlags.Static);

            if (methon != null)
            {
                methon.Invoke(null, null);
            }
        }
    }
}