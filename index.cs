<!DOCTYPE html>
<html>
<head>
  <meta charset="UTF-8">
  <title>KiHan 应用下载</title>
  <script>
    function startDownload() {
      const manifestUrl = encodeURIComponent(
        "https://1328649047.github.io/hihost/manifest.json5"
      );
      window.location.href = `store://enterprise/manifest?url=${manifestUrl}`;
    }
  </script>
</head>
<body>
  <button onclick="startDownload()">点击安装 KiHan 应用</button>
</body>
</html>
