<template>
<div class="block">
  <div class="block__head">
    <slot name="head"></slot>
  </div>
  <div class="block__body">
    <slot name="body"></slot>
  </div>
</div>
</template>

<script>
export default {
  name: "ContentBlock"
}
</script>

<style scoped lang="scss">
.block {
  border-radius: 5px;
  border: 1px solid var(--black200);
  width: 100%;
  height: auto;
  &__head {
    background-color: var(--black25);
    padding:10px;
    border-top-right-radius: 5px;
    border-top-left-radius: 5px;
    color: var(--black900);
    border-bottom: 1px solid var(--black200);
  }
  &__body {
    padding:10px
  }
}
</style>