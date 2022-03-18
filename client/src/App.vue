<template>
  <div class="app">
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
  font-family: Roboto, sans-serif;
}

.app {
  min-height: 100vh;
  display: flex;
  background-color: var(--black);
}

.router-page-container {
  padding-top: 50px;
  width: 100%;
}
</style>
