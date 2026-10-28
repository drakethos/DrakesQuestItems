# DrakesQuestItems

## Unreleased

### Fixed

- Packaging only: the Hexium/Thunderstore zip now puts the DLL and every data folder under `plugins/`, so Gale and r2modman
  keep the folder structure (they flatten anything outside `plugins/`). A CI guard (`check-gale-layout.py`) fails the build
  if that ever regresses. No code or behaviour change for players.

## 0.1.0
- Phase 1 scaffold.
