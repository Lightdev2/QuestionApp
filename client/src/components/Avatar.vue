<template>
<div class="avatar">
  <slot name="icon"></slot>
</div>
</template>

<script>
export default {
  name: "Avatar"
}
</script>

<style scoped>
.avatar {
  width: 25px;
  height: 25px;
  background-color: aliceblue;
}
</style>
