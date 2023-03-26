# Chrome DevTools Protocol

Repository contains the configuration for generating C# Chrome DevTools Protocol Library from the OpenAPI specification.

> see https://aka.ms/autorest

```yaml
input-file: 
  - ./openapi-specs/Accessibility.events.json
  - ./openapi-specs/Accessibility.types.json
  - ./openapi-specs/Animation.events.json
  - ./openapi-specs/Animation.types.json
  - ./openapi-specs/Audits.events.json
  - ./openapi-specs/Audits.types.json
  - ./openapi-specs/BackgroundService.events.json
  - ./openapi-specs/BackgroundService.types.json
  - ./openapi-specs/Browser.events.json
  - ./openapi-specs/Browser.types.json
  - ./openapi-specs/Cast.events.json
  - ./openapi-specs/Cast.types.json
  - ./openapi-specs/Console.events.json
  - ./openapi-specs/Console.types.json
  - ./openapi-specs/CSS.events.json
  - ./openapi-specs/CSS.types.json
  - ./openapi-specs/Database.events.json
  - ./openapi-specs/Database.types.json
  - ./openapi-specs/Debugger.events.json
  - ./openapi-specs/Debugger.types.json
  - ./openapi-specs/DeviceAccess.events.json
  - ./openapi-specs/DeviceAccess.types.json
  - ./openapi-specs/DOM.events.json
  - ./openapi-specs/DOM.types.json
  - ./openapi-specs/DOMStorage.events.json
  - ./openapi-specs/DOMStorage.types.json
  - ./openapi-specs/Emulation.events.json
  - ./openapi-specs/Fetch.events.json
  - ./openapi-specs/Fetch.types.json
  - ./openapi-specs/HeapProfiler.events.json
  - ./openapi-specs/Input.events.json
  - ./openapi-specs/Input.types.json
  - ./openapi-specs/Inspector.events.json
  - ./openapi-specs/IO.types.json
  - ./openapi-specs/LayerTree.events.json
  - ./openapi-specs/LayerTree.types.json
  - ./openapi-specs/Log.events.json
  - ./openapi-specs/Log.types.json
  - ./openapi-specs/Media.events.json
  - ./openapi-specs/Media.types.json
  - ./openapi-specs/Network.events.json
  - ./openapi-specs/Network.types.json
  - ./openapi-specs/Overlay.events.json
  - ./openapi-specs/Page.events.json
  - ./openapi-specs/Page.types.json
  - ./openapi-specs/Performance.events.json
  - ./openapi-specs/Performance.types.json
  - ./openapi-specs/PerformanceTimeline.events.json
  - ./openapi-specs/PerformanceTimeline.types.json
  - ./openapi-specs/Preload.events.json
  - ./openapi-specs/Preload.types.json
  - ./openapi-specs/Profiler.events.json
  - ./openapi-specs/Profiler.types.json
  - ./openapi-specs/Runtime.events.json
  - ./openapi-specs/Runtime.types.json
  - ./openapi-specs/Security.events.json
  - ./openapi-specs/Security.types.json
  - ./openapi-specs/ServiceWorker.events.json
  - ./openapi-specs/ServiceWorker.types.json
  - ./openapi-specs/Storage.events.json
  - ./openapi-specs/Storage.types.json
  - ./openapi-specs/Target.events.json
  - ./openapi-specs/Target.types.json
  - ./openapi-specs/Tethering.events.json
  - ./openapi-specs/Tracing.events.json
  - ./openapi-specs/Tracing.types.json
  - ./openapi-specs/WebAudio.events.json
  - ./openapi-specs/WebAudio.types.json
  - ./openapi-specs/WebAuthn.events.json
  - ./openapi-specs/WebAuthn.types.json

directive:
  - from: Accessibility.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Accessibility.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Animation.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Animation.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Audits.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Audits.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: BackgroundService.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: BackgroundService.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Browser.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Browser.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Cast.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Cast.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Console.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Console.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: CSS.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: CSS.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Database.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Database.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Debugger.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Debugger.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: DeviceAccess.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: DeviceAccess.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: DOM.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: DOM.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: DOMStorage.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: DOMStorage.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Emulation.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Fetch.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Fetch.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: HeapProfiler.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Input.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Input.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Inspector.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: IO.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: LayerTree.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: LayerTree.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Log.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Log.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Media.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Media.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Network.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Network.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Overlay.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Page.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Page.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Performance.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Performance.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: PerformanceTimeline.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: PerformanceTimeline.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Preload.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Preload.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Profiler.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Profiler.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Runtime.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Runtime.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Security.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Security.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: ServiceWorker.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: ServiceWorker.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Storage.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Storage.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Target.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Target.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Tethering.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Tracing.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: Tracing.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: WebAudio.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: WebAudio.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: WebAuthn.events.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }

  - from: WebAuthn.types.json
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }


generation1-convenience-client: true
namespace:  Chrome.DevTools
output-folder: ./src/Generated
save-code-model: true
client-side-validation: false
clear-output-folder: true
save-inputs: true
library-name: "Chrome.DevTools"

csharp:
  model-visibility: public
  model-public-field: true
  model-formats: json
  model-usage: model,input,output,converter

modelerfour:
  use-model-namespace: true
  # https://github.com/Azure/autorest/blob/f1e3be9399c5c8d9074ded877bbd10816954c891/packages/extensions/modelerfour/readme.md?plain=1#L58
  lenient-model-deduplication: true
  resolve-schema-name-collisons: true
```