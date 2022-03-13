<template>
  <div>
    <top-app-nav/>
    <router-view></router-view>
  </div>
</template>

<script>
import TopAppNav from "@/components/TopAppNav";

export default {
  name: "App",
  components: {
    TopAppNav,
  }
}
</script>
<style lang="scss">
@import "styles/normalize";
@import "styles/colors";
@import "styles/gloabal";
* {
  box-sizing: border-box;
}
</style>
