using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using System.Reflection;

namespace data_layer {
    public class VehicleTxService {
        public static List<VehicleTx> GetVehicleTx() {
            List<VehicleTx> data;
            var db = new Database("clan-db");
            data = db.Fetch<VehicleTx>("select * from vehicle_tx");
            return data;
        }


        public static PropertyInfo[] GetColumns() {
            PropertyInfo[] propertyInfos;
            propertyInfos = typeof(VehicleTx).GetProperties(BindingFlags.Public);
            return propertyInfos;
        }
    }

    public class TestService {
        public static List<ColumnDefinition> GetColumnDefinitions() {
            var columnDefinitions = new List<ColumnDefinition>();
            columnDefinitions.Add(new ColumnDefinition { title = "Id", field = "id", visible = false  });
            columnDefinitions.Add(new ColumnDefinition { title = "StatId", field = "StatId", visible = false });
            columnDefinitions.Add(new ColumnDefinition { title = "Battles", field = "Battles", width = "100", editor = "input" });
            columnDefinitions.Add(new ColumnDefinition { title = "Wins", field = "Wins", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Losses", field = "Losses", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Hits Received", field = "DirectHitsReceived", width="150" });
            columnDefinitions.Add(new ColumnDefinition { title = "Piercings Received", field = "PiercingsReceived", width="200" });
            columnDefinitions.Add(new ColumnDefinition { title = "Piercings", field = "Piercings", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Xp", field = "Xp", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Survived Battles", field = "SurvivedBattles", width="150" });
            columnDefinitions.Add(new ColumnDefinition { title = "Dropped Capture Points", field = "DroppedCapturePoints", width="200" });
            columnDefinitions.Add(new ColumnDefinition { title = "Draws", field = "Draws", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Damage Received", field = "DamageReceived", width="200" });
            columnDefinitions.Add(new ColumnDefinition { title = "Damage Dealt", field = "DamageDealt", width="150" });
            columnDefinitions.Add(new ColumnDefinition { title = "Frags", field = "Frags", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Capture Points", field = "CapturePoints", width="150" });
            columnDefinitions.Add(new ColumnDefinition { title = "Hits", field = "Hits", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Shots", field = "Shots", width="100" });
            columnDefinitions.Add(new ColumnDefinition { title = "Date Added", field = "DateAdded", width="150" });
            return columnDefinitions;
        }
    }

    public class ColumnDefinition {
        public string title { get; set; }

        public string field { get; set; }

        public bool visible { get; set; } = true;

        public string width { get; set; }

        public string editor { get; set; }

        public dynamic editorParams { get; set; }

        public string hozAlign { get; set; }

        public string formatter { get; set; }

        public string sorter { get; set; }
    }

    [TableName("vehicle_tx")]
    [PrimaryKey("Id")]
    public class VehicleTx {
        //   , xp, survived_battles, dropped_capture_points, draws, battles, damage_received, avg_damage_assisted, frags, stun_number, capture_points, stun_assisted_damage, hits, battle_avg_xp, wins, losses, damage_dealt, shots, date_added, clan_id, account_id, tx_stage, tank_id
        public int Id { get; set; }

        [Column("stat_id")]
        public string StatId { get; set; }

        [Column("spotted")]
        public int? Spotted { get; set; }

        [Column("direct_hits_received")]
        public int? DirectHitsReceived { get; set; }

        [Column("piercings_received")]
        public int? PiercingsReceived { get; set; }

        [Column("piercings")]
        public int? Piercings { get; set; }

        [Column("xp")]
        public int? Xp { get; set; }

        [Column("survived_battles")]
        public int? SurvivedBattles { get; set; }

        [Column("dropped_capture_points")]
        public int? DroppedCapturePoints { get; set; }

        [Column("draws")]
        public int? Draws { get; set; }

        [Column("battles")]
        public int? Battles { get; set; }

        [Column("damage_received")]
        public int? DamageReceived { get; set; }

        [Column("avg_damage_assisted")]
        public decimal? AvgDamageAssisted { get; set; }

        [Column("frags")]
        public int? Frags { get; set; }

        [Column("stun_number")]
        public int? StunNumber { get; set; }

        [Column("capture_points")]
        public int? CapturePoints { get; set; }

        [Column("stun_assisted_damage")]
        public int? StunAssistedDamage { get; set; }

        [Column("hits")]
        public int? Hits { get; set; }

        [Column("battle_avg_xp")]
        public decimal? BattleAvgXp { get; set; }

        [Column("wins")]
        public int? Wins { get; set; }

        [Column("losses")]
        public int? Losses { get; set; }

        [Column("damage_dealt")]
        public int? DamageDealt { get; set; }

        [Column("shots")]
        public int? Shots { get; set; }

        [Column("date_added")]
        public string DateAdded { get; set; }

        [Column("clan_id")]
        public int? ClanId { get; set; }

        [Column("account_id")]
        public int? AccountId { get; set; }

        [Column("tx_stage")]
        public int? TxStage { get; set; }

        [Column("tank_id")]
        public int? TankId { get; set; }

    }


}
