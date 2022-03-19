<template>
  <div class="context-block">
    <div @click.stop="toggleDropDown">
      <slot name="icon"></slot>
    </div>
    <div class="context-block__dropdown" v-if="isShowDropDown">
      <slot name="content"></slot>
    </div>
  </div>
</template>

<script>
const activeBlock = ref(0)
let idCounter = 0;
export default {
  name: "ContentBlock",
};
</script>

<script setup>
import { ref, onMounted, onUnmounted, watch } from "vue";
const isShowDropDown = ref(false);
let selfBlockId = null;
const toggleDropDown = () => {
  if(!isShowDropDown.value) {
    activeBlock.value = selfBlockId;
  }
  isShowDropDown.value = !isShowDropDown.value
}
const closeDropDown = ({ target }) => {
  if (!target.closest("context-block")) {
    isShowDropDown.value = false;
  }
};
watch(() => activeBlock.value, () => {
  if(activeBlock.value !== selfBlockId) {
    isShowDropDown.value = false;
  }
})
onMounted(() => {
  document.addEventListener("click", closeDropDown);
  selfBlockId = idCounter;
  idCounter = idCounter + 1;
});
onUnmounted(() => {
  document.removeEventListener("click", closeDropDown);
});
</script>

<style scoped lang="scss">
.context-block {
  position: relative;
  &__dropdown {
    position: absolute;
    background-color: red;
    min-height: 505px;
    width: 375px;
    right: 0;
    border: 1px solid var(--black200);
    background-color: var(--black);
    @media screen and (max-width: 760px){
      position: fixed;
      top: 55px;
      width:100%;
      right: 0;
    }
  }
}
</style>
