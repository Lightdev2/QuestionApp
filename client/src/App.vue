<template>
  <div style="height: 100%">
    <top-app-nav/>
    <div class="router-page-container">
      <router-view></router-view>
    </div>
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
  font-family: Roboto,sans-serif;
}
html,body {
  height: 100%;
}
#app {
  min-height: 100%;
  height: 1px;
  background-color: var(--black);
}
.router-page-container {
  padding-top: 50px;
  height: 100%;
}
</style>
