using System;
using System.Reflection;

namespace SavegameToolkitAdditions
{
    public enum TeamType {
        [TeamType(false)] NonPlayer,
        [TeamType(true)] Player,
        [TeamType(true)] Tribe,
        [TeamType(true)] Breeding,
        [TeamType(true)] Unknown
    }

    public class TeamTypeAttribute : Attribute {
        public bool Tamed { get; }

        public TeamTypeAttribute(bool tamed) {
            Tamed = tamed;
        }
    }

    public static class TeamTypes {
        private const int PLAYER_START = 50_000;
        private const int TRIBE_START = 1_000_000_000;
        private const int BREEDING_ID = 2_000_000_000;

        public static TeamType ForTeam(int teamId) {
            if (teamId < PLAYER_START) {
                return TeamType.NonPlayer;
            }

            if (teamId < TRIBE_START) {
                return TeamType.Player;
            }

            if (teamId < BREEDING_ID) {
                return TeamType.Tribe;
            }

            return teamId == BREEDING_ID ? TeamType.Breeding : TeamType.Unknown;
        }

        public static bool IsTamed(this TeamType teamType) {
            TeamTypeAttribute teamTypeAttribute = getAttr(teamType);
            return teamTypeAttribute?.Tamed ?? false;
        }

        private static TeamTypeAttribute getAttr(TeamType teamType) {
            return (TeamTypeAttribute)Attribute.GetCustomAttribute(forValue(teamType), typeof(TeamTypeAttribute));
        }

        private static MemberInfo forValue(TeamType teamType) {
            return typeof(TeamType).GetField(Enum.GetName(typeof(TeamType), teamType));
        }
    }
}
