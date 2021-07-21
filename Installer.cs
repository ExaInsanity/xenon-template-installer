using System;

using Xenon.InstallerLoader;
using Xenon.InstallerLoader.Metadata;

namespace Template.Installer
{
	public class Installer : IInstaller // the class must be public and cannot be abstract.
	{
		public String Id => throw new NotImplementedException();

		public Xenon.TypeLib.Version Version => throw new NotImplementedException();

		public InstallerEnvironment Environment => throw new NotImplementedException();

		public void Disable()
		{
			throw new NotImplementedException();
		}

		public void Initialize()
		{
			throw new NotImplementedException();
		}

		public String[] ListTags()
		{
			throw new NotImplementedException();
		}

		public String[] ListVersions()
		{
			throw new NotImplementedException();
		}

		public String[] ListVersions(params String[] tags)
		{
			throw new NotImplementedException();
		}
	}
}
