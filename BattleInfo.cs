using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading.Tasks;
using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleViewer.Plugins.ViewModels;
using Grabacr07.KanColleViewer.Plugins.Views;
using Grabacr07.KanColleWrapper;

namespace Grabacr07.KanColleViewer.Plugins
{
	[Export(typeof(IPlugin))]
	[Export(typeof(ITool))]
	[Export(typeof(ISettings))]
	[ExportMetadata("Guid", "45BF5FE6-7D81-4978-8B8A-84FD80BBEC10")]
	[ExportMetadata("Title", "BattleInfo")]
	[ExportMetadata("Description", "戦闘情報")]
	[ExportMetadata("Version", "1.0")]
	[ExportMetadata("Author", "hiralius")]
	public class BattleInfo : IPlugin, ITool, ISettings
	{
		private PortalViewModel portalViewModel;

		string ITool.Name => "MasterView";

		object ITool.View => new Portal { DataContext = this.portalViewModel };

		object ISettings.View => new Settings();

		public void Initialize()
		{
			portalViewModel = new PortalViewModel(KanColleClient.Current.Proxy);
		}

	}
}
