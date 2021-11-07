using JKMP.Core.Logging;
using JKMP.Plugin.Multiplayer.Game.UI;
using Serilog;

namespace JKMP.Plugin.Multiplayer.Game.Entities
{
    public class TitleScreenEntity : BaseManagerEntity
    {
        private static readonly ILogger Logger = LogManager.CreateLogger<TitleScreenEntity>();

        protected override void OnFirstUpdate()
        {
            UIManager.PushShowCursor();
        }

        protected override void OnDestroy()
        {
            UIManager.PopShowCursor();
        }
    }
}