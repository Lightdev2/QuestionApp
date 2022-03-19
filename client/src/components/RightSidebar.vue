<template>
  <div class="sidebar">
    <slot name="content"></slot>
  </div>
</template>

<script>
export default {
  name: "RightSidebar"
}
</script>

<style scoped>
.sidebar {
  width: 300px
}
</style>