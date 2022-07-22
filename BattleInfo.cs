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
	[ExportMetadata("Guid", "CED9A7F7-CEB5-4FD0-9DDA-7B10AF5358A5")]
	[ExportMetadata("Title", "BattleInfo")]
	[ExportMetadata("Description", "戦闘海域・戦闘情報を表示します。")]
	[ExportMetadata("Version", "1.0")]
	[ExportMetadata("Author", "@hiralius")]
	public class BattleInfo : IPlugin, ITool
	{
		private PortalViewModel portalViewModel;

		string ITool.Name => "BattileInfo";

		object ITool.View => new Portal { DataContext = this.portalViewModel };

		public void Initialize()
		{
			portalViewModel = new PortalViewModel(KanColleClient.Current.Proxy);
		}

	}
}
