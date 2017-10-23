using System.Runtime.Serialization;

/// <summary>
/// Discord game status namespace
/// </summary>
namespace DiscordGameStatus
{
    /// <summary>
    /// Configuration data contract class
    /// </summary>
    [DataContract]
    public class ConfigDataContract
    {
        /// <summary>
        /// Game status
        /// </summary>
        [DataMember]
        private string gameStatus = "";

        /// <summary>
        /// Game status
        /// </summary>
        public string GameStatus
        {
            get
            {
                return gameStatus;
            }
            set
            {
                if (value != null)
                {
                    gameStatus = value;
                }
            }
        }
    }
}
