# GitHub Copilot Instructions for EM Ancient Technology (Continued)

## Mod Overview and Purpose

**EM Ancient Technology (Continued)** is an update to **Moshs** mod, aimed at enriching early/tribal gameplay in RimWorld by introducing a unique set of defenses and weaponry. Unlike traditional industrial tech, this mod offers a more advanced yet specialized approach to colony building, using ancient mechanite technology derived from blood sacrifices.

## Key Features and Systems

### Buildings
- **Excavation**: Allows miners to produce mechanite fragments, essential for crafting various items.
- **Mechanists Table**: Enables researchers to sort through dirt piles to create useful items.
- **Mechanite Grave**: Disposes of corpses and provides resources, requiring blood crops to operate.

### Plants
- **Bottle Gourd**: An inedible plant used to preserve blood for longer periods.

### Turrets
- **Fear Effigy/Totem**: Fast rate of fire, low damage, causes debuff on targets.
- **Dart Trap/Turret**: Fast rate of fire, low damage, area denial for small areas.
- **Acid Launcher**: Slow rate of fire, long range, explosive, low damage but major debuffs.
- **Rock Launcher**: Slow rate of fire, minimum range, large range, high damage but hard to hit specific targets.

### Armor
- Three different helmets with various bonuses, requiring mechanite resources.

### Weapons
- **Melee**: Six weapons, including poison, burn, bleeding, and fear effects.
- **Guns**: Six guns with unique damage types such as chemical charges, acid, and slow debuffs.

### Specializations
- Three specializations unlock different guns and armor sets.

### Damage Types
- **Fear**: Lowers manipulation and mood.
- **Slow**: Lowers consciousness, low/no damage.
- **Acid**: Lowers speed and burns.

## Coding Patterns and Conventions

### C# Files
- **ThingDefOf.cs**: Contains definitions for various game objects.
- **Verb_EMSacrifice.cs**: Manages the mechanics of blood sacrifice.

### XML Integration
- **DamageDefs**: Defines custom damage types.
- **HeDiffDefs**: Manages health effects and thoughts.
- **Maneuvers**: Defines combat maneuvers.
- **SoundDefs**: Manages sound effects.

## Harmony Patching

**EM Ancient Technology (Continued)** utilizes Harmony patches to extend and modify existing RimWorld functionality. Key patches include:

- **Building Excavation**: Modifies the behavior of miners to produce mechanite fragments.
- **Mechanists Table**: Enhances the researcher's ability to process dirt.
- **Mechanite Grave**: Adjusts corpse disposal to provide resources.

## Suggestions for Copilot

### General Suggestions
- Use Copilot to generate or refine XML definitions for new buildings, plants, turrets, armor, and weapons.
- Utilize Copilot to assist in creating new C# classes and methods for handling unique game mechanics, such as blood sacrifice or mechanite resource management.

### XML File Generation
- **DamageDefs**: Create new `DamageDef` entries for custom damage types.
  xml
  <DamageDef>
    <defName>EM_FearDamage</defName>
    <label>Fear</label>
    <description>Causes fear and reduces manipulation and mood.</description>
  </DamageDef>
  
- **HeDiffDefs**: Define new `HediffDef` entries for health effects.
  xml
  <HediffDef>
    <defName>EM_FearEffect</defName>
    <label>Fear Effect</label>
    <description>Reduced manipulation and mood.</description>
  </HediffDef>
  
- **Maneuvers**: Add new `ManeuverDef` entries for combat maneuvers.
  xml
  <ManeuverDef>
    <defName>EM_FearAttack</defName>
    <label>Fear Attack</label>
    <description>Causes fear on the target.</description>
  </ManeuverDef>
  
- **SoundDefs**: Create new `SoundDef` entries for sound effects.
  xml
  <SoundDef>
    <defName>EM_SacrificeSound</defName>
    <label>Sacrifice Sound</label>
    <subSounds>
      <li>
        <defName>Sounds/Effects/Explode</defName>
      </li>
    </subSounds>
  </SoundDef>
  

### C# File Generation
- **ThingDefOf.cs**: Define new `ThingDef` entries for custom game objects.
  csharp
  namespace RimWorld
  {
      public static class ThingDefOf
      {
          public static ThingDef EM_FearEffigyTotem;
          public static ThingDef EM_DartTrapTurret;
          // Add more ThingDef entries as needed
      }
  }
  
- **Verb_EMSacrifice.cs**: Create new verbs for unique mechanics.
  csharp
  using Verse;

  namespace RimWorld
  {
      public class Verb_EMSacrifice : Verb
      {
          public override bool TryCastShot()
          {
              // Implement sacrifice logic
              return base.TryCastShot();
          }
      }
  }
  

### Best Practices
- Always validate generated code to ensure it aligns with RimWorld conventions and standards.
- Utilize Copilot to explore and understand existing mod codebases before generating new content.
- Regularly test and refine generated code to ensure it functions as intended within the mod.

By following these guidelines, you can leverage GitHub Copilot to enhance the development process for **EM Ancient Technology (Continued)**, ensuring a rich and immersive early/tribal gameplay experience for players.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

