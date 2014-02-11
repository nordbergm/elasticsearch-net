using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using NUnit.Framework;
using Nest.Tests.Integration.Yaml;


namespace Nest.Tests.Integration.Yaml.Info
{
	public partial class InfoTests
	{	


		public class InfoReturnsBodyTests : YamlTestsBase
		{
			[Test]
			public void InfoReturnsBodyTest()
			{	

				//do info 
				this.Do(()=> this._client.InfoGet());

				//match _response.status: 
				this.IsMatch(_response.status, 200);

				//is_true _response.ok; 
				this.IsTrue(_response.ok);

				//is_true _response.name; 
				this.IsTrue(_response.name);

				//is_true _response.tagline; 
				this.IsTrue(_response.tagline);

				//is_true _response.version; 
				this.IsTrue(_response.version);

				//is_true _response.version.number; 
				this.IsTrue(_response.version.number);

			}
		}
	}
}
