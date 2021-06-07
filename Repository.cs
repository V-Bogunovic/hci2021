using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hci2021.Models;
using EventType = hci2021.Models.Type;
using Type = System.Type;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace hci2021
{
    class Repository
    {
        public List<(Guid event_id, Guid tag_id)> _event_tags = new List<(Guid event_id, Guid tag_id)>();
        public Dictionary<Guid, Event> _events = new Dictionary<Guid, Event>();
        public Dictionary<Guid, Tag> _tags = new Dictionary<Guid, Tag>();
        public Dictionary<Guid, EventType> _types = new Dictionary<Guid, EventType>();

        public Dictionary<Guid, (double x, double y)> _map_positions = new Dictionary<Guid, (double x, double y)>();

        private readonly string _events_file;
        private readonly string _tags_file;
        private readonly string _types_file;
        private readonly string _event_tags_file;
        private readonly string _map_positions_file;

        public Repository()
        {
            _events_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.events");
            _tags_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.tags");
            _types_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.types");
            _event_tags_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.event_tags");
            _map_positions_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.map_positions");

            DeserializeFile(_events_file, _events);
            DeserializeFile(_tags_file, _tags);
            DeserializeFile(_types_file, _types);
            DeserializeFile(_event_tags_file, _event_tags);
            DeserializeFile(_map_positions_file, _map_positions);
        }
        private void DeserializeFile<T>(string filepath, T variable)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(filepath))
            {
                try
                {
                    stream = File.Open(filepath, FileMode.Open);
                    variable = (T)formatter.Deserialize(stream);
                }
                catch
                {
                    // 
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
            else
            {

            }
        }

        private void SerializeFile<T>(string filepath, T variable)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(filepath, FileMode.OpenOrCreate);
                formatter.Serialize(stream, variable);
            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }
    }
}
