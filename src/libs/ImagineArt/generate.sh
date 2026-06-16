#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Manual OpenAPI source based on the official ImagineArt Apidog docs:
# - https://reference.imagine.art/api-10672910.md
# - https://reference.imagine.art/api-11959030.md
# - https://reference.imagine.art/api-10690786.md
# - https://reference.imagine.art/api-10695409.md
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace ImagineArt \
  --clientClassName ImagineArtClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

rm -rf ../../cli/ImagineArt.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/ImagineArt.CLI \
  --sdk-project ../../libs/ImagineArt/ImagineArt.csproj \
  --targetFramework net10.0 \
  --namespace ImagineArt \
  --clientClassName ImagineArtClient \
  --package-id ImagineArt.CLI \
  --tool-command-name imagine-art \
  --user-secrets-id ImagineArt.CLI \
  --api-key-env-var IMAGINEART_API_KEY \
  --base-url-env-var IMAGINEART_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
