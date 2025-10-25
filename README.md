# GateBLiftGrenadeFix

## Description
A simple EXILED plugin that fixes an invisible hole left by developers under the Gate B elevator where grenades would fall through and disappear

## Features
- Creates an invisible barrier (transparent cube) in the problematic area near Gate B elevator
- Restores the ability to properly use grenades near the elevator by preventing them from falling through the geometry
- Does not affect normal gameplay or player movement

## Installation
1. Download the latest release
2. Place `GateBLiftGrenadeFix.dll` in your `EXILED/Plugins` folder
3. Restart your server

## Configuration
```yaml
gate_b_lift_grenade_fix_plugin:
  is_enabled: true
  debug: true
  # Barrier position relative to Gate B room
  position:
    x: 2.9
    y: 2.87
    z: -6
  # Barrier scale
  scale:
    x: 1
    y: 0.05
    z: 1
