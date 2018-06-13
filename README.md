# CFAppInsights

Sample app that shows how to dump MS application insights to stdout, so they're available in Cloud Foundry logs.

## Usage
- Open sln and compile in VS 2017
- cf push appinsights -s windows2016
- cf logs appinsights

Sample Output
```
AI: {"name":"Microsoft.ApplicationInsights.Dev.Request","time":"2018-06-13T13:37:54.4768238Z","tags":{"ai.cloud.roleInstance":"DESKTOP-AE7F2U5","ai.operation.id":"bKb+ShvJ0l8=","ai.operation.name":"GET Home/Index","ai.location.ip":"::1","ai.internal.sdkVersion":"web:2.5.1-195","ai.internal.nodeName":"DESKTOP-AE7F2U5"},"data":{"baseType":"RequestData","baseData":{"ver":2,"id":"|bKb+ShvJ0l8=.5de39260_","name":"GET Home/Index","duration":"00:00:00.0008097","success":true,"responseCode":"200","url":"http://localhost:52667/","properties":{"DeveloperMode":"true","_MS.ProcessedByMetricExtractors":"(Name:'Requests', Ver:'1.0')"}}}}
AI: {"name":"Microsoft.ApplicationInsights.Dev.Metric","time":"2018-06-13T13:37:01.0017972Z","tags":{"ai.cloud.roleInstance":"DESKTOP-AE7F2U5","ai.internal.sdkVersion":"m-agg:2.5.1-172"},"data":{"baseType":"MetricData","baseData":{"ver":2,"metrics":[{"name":"Server response time","kind":"Aggregation","value":212.5494,"count":250,"min":0.7557,"max":1.2927,"stdDev":0.0705776978530826}],"properties":{"_MS.MetricId":"requests/duration","_MS.IsAutocollected":"True","_MS.AggregationIntervalMs":"60000","DeveloperMode":"true","Request.Success":"True"}}}}
```
