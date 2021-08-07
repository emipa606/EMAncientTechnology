using RimWorld;
using Verse;

namespace EM_MM
{
    // Token: 0x02000002 RID: 2
    public class Verb_EMSacrifice : Verb
    {
        // Token: 0x04000001 RID: 1
        private const int DurationTicks = 600;

        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        protected override bool TryCastShot()
        {
            bool result;
            if (currentTarget.HasThing && currentTarget.Thing.Map != caster.Map)
            {
                result = false;
            }
            else
            {
                var powerBeam =
                    (PowerBeam) GenSpawn.Spawn(ThingDefOf.EM_EyeofGodEffect, currentTarget.Cell, caster.Map);
                powerBeam.duration = 600;
                powerBeam.instigator = caster;
                powerBeam.weaponDef = EquipmentSource?.def;
                powerBeam.StartStrike();
                if (EquipmentSource is {Destroyed: false})
                {
                    EquipmentSource.Destroy();
                }

                result = true;
            }

            return result;
        }

        // Token: 0x06000002 RID: 2 RVA: 0x0000212C File Offset: 0x0000032C
        public override float HighlightFieldRadiusAroundTarget(out bool needLOSToCenter)
        {
            needLOSToCenter = false;
            return 15f;
        }
    }
}