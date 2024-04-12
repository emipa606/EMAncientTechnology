using RimWorld;
using Verse;

namespace EM_MM;

public class Verb_EMSacrifice : Verb
{
    private const int DurationTicks = 600;

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
                (PowerBeam)GenSpawn.Spawn(ThingDefOf.EM_EyeofGodEffect, currentTarget.Cell, caster.Map);
            powerBeam.duration = DurationTicks;
            powerBeam.instigator = caster;
            powerBeam.weaponDef = EquipmentSource?.def;
            powerBeam.StartStrike();
            if (EquipmentSource is { Destroyed: false })
            {
                EquipmentSource.Destroy();
            }

            result = true;
        }

        return result;
    }

    public override float HighlightFieldRadiusAroundTarget(out bool needLOSToCenter)
    {
        needLOSToCenter = false;
        return 15f;
    }
}