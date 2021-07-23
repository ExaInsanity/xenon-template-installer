using System;

using Xenon.InstallerLoader;

namespace Template.Installer
{
	public class InstallHandler : IInstallHandler
	{
		public void Install(String version, String installDirectory)
		{
			throw new NotImplementedException();
		}

		public void PatchVersionMeta(String version, String installDirectory) // mark as [Obsolete] if this is a server installer, keep the NIE. if this is a client, implement as usual.
		{
			throw new NotImplementedException();
		}
	}
}
