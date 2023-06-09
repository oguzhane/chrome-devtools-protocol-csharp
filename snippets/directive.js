const template = `
  - from: <fileName>
    where: $.components.schemas
    transform: >
      for (var path in $)
      {
        $[path]["x-accessibility"] = "public"
        $[path]["x-csharp-formats"] = "json"
        $[path]["x-csharp-usage"] = "model,input,output,converter"
      }`;

const fileNames =
    [
        "./openapi-specs/Accessibility.events.json",
        "./openapi-specs/Accessibility.types.json",
        "./openapi-specs/Animation.events.json",
        "./openapi-specs/Animation.types.json",
        "./openapi-specs/Audits.events.json",
        "./openapi-specs/Audits.types.json",
        "./openapi-specs/BackgroundService.events.json",
        "./openapi-specs/BackgroundService.types.json",
        "./openapi-specs/Browser.events.json",
        "./openapi-specs/Browser.types.json",
        "./openapi-specs/Cast.events.json",
        "./openapi-specs/Cast.types.json",
        "./openapi-specs/Console.events.json",
        "./openapi-specs/Console.types.json",
        "./openapi-specs/CSS.events.json",
        "./openapi-specs/CSS.types.json",
        "./openapi-specs/Database.events.json",
        "./openapi-specs/Database.types.json",
        "./openapi-specs/Debugger.events.json",
        "./openapi-specs/Debugger.types.json",
        "./openapi-specs/DeviceAccess.events.json",
        "./openapi-specs/DeviceAccess.types.json",
        "./openapi-specs/DOM.events.json",
        "./openapi-specs/DOM.types.json",
        "./openapi-specs/DOMStorage.events.json",
        "./openapi-specs/DOMStorage.types.json",
        "./openapi-specs/Emulation.events.json",
        "./openapi-specs/Fetch.events.json",
        "./openapi-specs/Fetch.types.json",
        "./openapi-specs/HeapProfiler.events.json",
        "./openapi-specs/Input.events.json",
        "./openapi-specs/Input.types.json",
        "./openapi-specs/Inspector.events.json",
        "./openapi-specs/IO.types.json",
        "./openapi-specs/LayerTree.events.json",
        "./openapi-specs/LayerTree.types.json",
        "./openapi-specs/Log.events.json",
        "./openapi-specs/Log.types.json",
        "./openapi-specs/Media.events.json",
        "./openapi-specs/Media.types.json",
        "./openapi-specs/Network.events.json",
        "./openapi-specs/Network.types.json",
        "./openapi-specs/Overlay.events.json",
        "./openapi-specs/Page.events.json",
        "./openapi-specs/Page.types.json",
        "./openapi-specs/Performance.events.json",
        "./openapi-specs/Performance.types.json",
        "./openapi-specs/PerformanceTimeline.events.json",
        "./openapi-specs/PerformanceTimeline.types.json",
        "./openapi-specs/Preload.events.json",
        "./openapi-specs/Preload.types.json",
        "./openapi-specs/Profiler.events.json",
        "./openapi-specs/Profiler.types.json",
        "./openapi-specs/Runtime.events.json",
        "./openapi-specs/Runtime.types.json",
        "./openapi-specs/Security.events.json",
        "./openapi-specs/Security.types.json",
        "./openapi-specs/ServiceWorker.events.json",
        "./openapi-specs/ServiceWorker.types.json",
        "./openapi-specs/Storage.events.json",
        "./openapi-specs/Storage.types.json",
        "./openapi-specs/Target.events.json",
        "./openapi-specs/Target.types.json",
        "./openapi-specs/Tethering.events.json",
        "./openapi-specs/Tracing.events.json",
        "./openapi-specs/Tracing.types.json",
        "./openapi-specs/WebAudio.events.json",
        "./openapi-specs/WebAudio.types.json",
        "./openapi-specs/WebAuthn.events.json",
        "./openapi-specs/WebAuthn.types.json"
        ];

for (const fileName of fileNames) {   
    // substitute file name in template
    let transformedData = template.replace("<fileName>", fileName);
    
    // print result
    console.log(transformedData);
}