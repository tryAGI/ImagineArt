#!/usr/bin/env bash
set -euo pipefail

# Manual OpenAPI source based on the official ImagineArt Apidog docs:
# - https://reference.imagine.art/api-10672910.md
# - https://reference.imagine.art/api-11959030.md
# - https://reference.imagine.art/api-10690786.md
# - https://reference.imagine.art/api-10695409.md

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace ImagineArt \
  --clientClassName ImagineArtClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
