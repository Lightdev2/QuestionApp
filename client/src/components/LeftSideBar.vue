<template>
  <div class="left-sidebar">
    <slot name="content"></slot>
  </div>
</template>

<script>
export default {
  name: "LeftSidebar",
}
</script>

<style scoped>
.left-sidebar {
  padding-top: 30px;
  width: 164px;
  border-right: 1px solid var(--black200);
  height: 100%;
  min-width: 164px;
}
</style>